using System.Threading.RateLimiting;
using DevElf.ArgumentValidation;

namespace DevElf.Threading.RateLimiting;

/// <summary>
/// Provides extension methods for <see cref="RateLimiter"/> to simplify applying
/// rate limiting to actions and requests.
/// </summary>
public static class RateLimiterExtensions
{
    private const int DefaultIdleTimeMicroseconds = 100;

    /// <summary>
    /// Applies rate limiting to an asynchronous action, automatically acquiring and
    /// releasing permits.
    /// </summary>
    /// <param name="limiter">The rate limiter to be used.</param>
    /// <param name="action">The action to execute once permits are acquired.</param>
    /// <param name="permitCount">
    /// The number of permits needed to execute the action. Must be positive.
    /// Defaults to 1.
    /// </param>
    /// <param name="idleTime">
    /// The time to wait between permit acquisition attempts when permits are not
    /// immediately available. When <see langword="null"/>, defaults to 100
    /// microseconds. This prevents busy-waiting while allowing responsive permit
    /// acquisition.
    /// </param>
    /// <param name="timeProvider">
    /// The <see cref="TimeProvider"/> to use for time-based operations during idle
    /// waits. When <see langword="null"/>, defaults to <see cref="TimeProvider.System"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to monitor for cancellation requests during permit acquisition and
    /// action execution.
    /// </param>
    /// <returns>A task that completes when the action has been executed.</returns>
    /// <exception cref="ArgumentNullException">
    /// If <paramref name="limiter"/> or <paramref name="action"/> is
    /// <see langword="null"/>.
    /// </exception>
    /// <exception cref="OperationCanceledException">
    /// If the <paramref name="cancellationToken"/> is canceled before or during
    /// execution.
    /// </exception>
    /// <remarks>
    /// <para>
    /// This method repeatedly attempts to acquire the specified number of permits.
    /// If permits are not immediately available, it waits for the specified
    /// <paramref name="idleTime"/> before trying again. Once permits are acquired,
    /// the action is executed and the permits are automatically released.
    /// </para>
    /// <para>
    /// The lease is properly disposed even if the action throws an exception,
    /// ensuring permits are returned to the limiter.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var limiter = new TokenBucketRateLimiter(new TokenBucketRateLimiterOptions
    /// {
    ///     TokenLimit = 10,
    ///     ReplenishmentPeriod = TimeSpan.FromSeconds(1),
    ///     TokensPerPeriod = 10
    /// });
    /// 
    /// await limiter.ApplyToAsync(
    ///     async ct => await SendEmailAsync(ct),
    ///     permitCount: 1,
    ///     cancellationToken: cancellationToken);
    /// </code>
    /// </example>
    public static async Task ApplyToAsync(
        this RateLimiter limiter,
        Func<CancellationToken, Task> action,
        int permitCount = 1,
        TimeSpan? idleTime = null,
        TimeProvider? timeProvider = null,
        CancellationToken cancellationToken = default)
    {
        limiter.ThrowIfNull();
        action.ThrowIfNull();

        timeProvider ??= TimeProvider.System;
        RateLimitLease lease;

        do
        {
            lease = await limiter.AcquireAsync(permitCount, cancellationToken).ConfigureAwait(false);

            if (!lease.IsAcquired)
            {
                lease.Dispose();
                await Task
                    .Delay(
                        idleTime ?? TimeSpan.FromMicroseconds(DefaultIdleTimeMicroseconds),
                        timeProvider,
                        cancellationToken)
                    .ConfigureAwait(false);
            }
        }
        while (!lease.IsAcquired);

        try
        {
            await action(cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            lease.Dispose();
        }
    }

    /// <summary>
    /// Applies rate limiting to an asynchronous request, automatically acquiring and
    /// releasing permits, and returns the result.
    /// </summary>
    /// <typeparam name="T">The type of the result returned by the request.</typeparam>
    /// <param name="limiter">The rate limiter to be used.</param>
    /// <param name="request">
    /// The request function to execute once permits are acquired.
    /// </param>
    /// <param name="permitCount">
    /// The number of permits needed to execute the request. Must be positive.
    /// Defaults to 1.
    /// </param>
    /// <param name="idleTime">
    /// The time to wait between permit acquisition attempts when permits are not
    /// immediately available. When <see langword="null"/>, defaults to 100
    /// microseconds. This prevents busy-waiting while allowing responsive permit
    /// acquisition.
    /// </param>
    /// <param name="timeProvider">
    /// The <see cref="TimeProvider"/> to use for time-based operations during idle
    /// waits. When <see langword="null"/>, defaults to <see cref="TimeProvider.System"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to monitor for cancellation requests during permit acquisition and
    /// request execution.
    /// </param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains
    /// the value returned by the request function.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// If <paramref name="limiter"/> or <paramref name="request"/> is
    /// <see langword="null"/>.
    /// </exception>
    /// <exception cref="OperationCanceledException">
    /// If the <paramref name="cancellationToken"/> is canceled before or during
    /// execution.
    /// </exception>
    /// <remarks>
    /// <para>
    /// This method repeatedly attempts to acquire the specified number of permits.
    /// If permits are not immediately available, it waits for the specified
    /// <paramref name="idleTime"/> before trying again. Once permits are acquired,
    /// the request is executed and the permits are automatically released.
    /// </para>
    /// <para>
    /// The lease is properly disposed even if the request throws an exception,
    /// ensuring permits are returned to the limiter.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
    /// {
    ///     PermitLimit = 5,
    ///     QueueLimit = 10
    /// });
    /// 
    /// var response = await limiter.ApplyToAsync(
    ///     async ct => await httpClient.GetAsync(url, ct),
    ///     permitCount: 1,
    ///     cancellationToken: cancellationToken);
    /// </code>
    /// </example>
    public static async Task<T> ApplyToAsync<T>(
        this RateLimiter limiter,
        Func<CancellationToken, Task<T>> request,
        int permitCount = 1,
        TimeSpan? idleTime = null,
        TimeProvider? timeProvider = null,
        CancellationToken cancellationToken = default)
    {
        limiter.ThrowIfNull();
        request.ThrowIfNull();

        timeProvider ??= TimeProvider.System;
        RateLimitLease lease;

        do
        {
            lease = await limiter.AcquireAsync(permitCount, cancellationToken).ConfigureAwait(false);

            if (!lease.IsAcquired)
            {
                lease.Dispose();
                await Task
                    .Delay(
                        idleTime ?? TimeSpan.FromMicroseconds(DefaultIdleTimeMicroseconds),
                        timeProvider,
                        cancellationToken)
                    .ConfigureAwait(false);
            }
        }
        while (!lease.IsAcquired);

        try
        {
            return await request(cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            lease.Dispose();
        }
    }
}

