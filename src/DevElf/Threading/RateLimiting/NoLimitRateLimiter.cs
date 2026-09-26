using System.Threading.RateLimiting;

namespace DevElf.Threading.RateLimiting;

/// <summary>
/// A <see cref="RateLimiter"/> implementation that imposes no limits on permit acquisition.
/// All requests for permits are immediately granted without any restrictions.
/// </summary>
/// <remarks>
/// <para>
/// This rate limiter is useful in scenarios where rate limiting needs to be conditionally
/// disabled or for testing purposes. It always returns acquired leases immediately,
/// regardless of the number of permits requested.
/// </para>
/// <para>
/// Use the singleton <see cref="Instance"/> to avoid unnecessary allocations.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Use the singleton instance
/// RateLimiter limiter = NoLimitRateLimiter.Instance;
/// 
/// // All acquisitions succeed immediately
/// using var lease = await limiter.AcquireAsync(permitCount: 100);
/// // lease.IsAcquired will always be true
/// </code>
/// </example>
public class NoLimitRateLimiter : RateLimiter
{
    /// <summary>
    /// Gets the singleton instance of <see cref="NoLimitRateLimiter"/>.
    /// </summary>
    /// <remarks>
    /// Using this instance avoids creating multiple instances of the same
    /// no-op rate limiter.
    /// </remarks>
    public static readonly NoLimitRateLimiter Instance = new();

    /// <summary>
    /// Gets the idle duration, which is always <see langword="null"/> for this limiter
    /// since there is never any waiting required.
    /// </summary>
    public override TimeSpan? IdleDuration { get; }

    /// <summary>
    /// Gets the rate limiter statistics. Always returns <see langword="null"/> since
    /// this limiter does not track any statistics.
    /// </summary>
    /// <returns>Always <see langword="null"/>.</returns>
    public override RateLimiterStatistics? GetStatistics() => null;

    /// <summary>
    /// Asynchronously acquires permits. Always succeeds immediately regardless of
    /// the permit count.
    /// </summary>
    /// <param name="permitCount">
    /// The number of permits to acquire. This parameter is ignored since all
    /// acquisitions succeed.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to monitor for cancellation requests. This parameter is ignored since
    /// the operation completes synchronously.
    /// </param>
    /// <returns>
    /// A <see cref="ValueTask{T}"/> that completes immediately with an acquired lease.
    /// </returns>
    protected override ValueTask<RateLimitLease> AcquireAsyncCore(int permitCount, CancellationToken cancellationToken)
        => ValueTask.FromResult(NoLimitLease.LeaseInstance);

    /// <summary>
    /// Attempts to acquire permits synchronously. Always succeeds immediately
    /// regardless of the permit count.
    /// </summary>
    /// <param name="permitCount">
    /// The number of permits to acquire. This parameter is ignored since all
    /// acquisitions succeed.
    /// </param>
    /// <returns>An acquired <see cref="RateLimitLease"/>.</returns>
    protected override RateLimitLease AttemptAcquireCore(int permitCount) => NoLimitLease.LeaseInstance;

    /// <summary>
    /// Represents a lease from <see cref="NoLimitRateLimiter"/> that is always acquired
    /// and contains no metadata.
    /// </summary>
    protected sealed class NoLimitLease : RateLimitLease
    {
        /// <summary>
        /// Gets the singleton instance of <see cref="NoLimitLease"/>.
        /// </summary>
        public static readonly RateLimitLease LeaseInstance = new NoLimitLease();

        /// <summary>
        /// Gets a value indicating whether the lease was acquired. Always returns
        /// <see langword="true"/>.
        /// </summary>
        public override bool IsAcquired => true;

        /// <summary>
        /// Gets the metadata names associated with this lease. Always returns an
        /// empty collection since this lease contains no metadata.
        /// </summary>
        public override IEnumerable<string> MetadataNames { get; } = [];

        /// <summary>
        /// Attempts to retrieve metadata by name. Always returns <see langword="false"/>
        /// since this lease contains no metadata.
        /// </summary>
        /// <param name="metadataName">The name of the metadata to retrieve.</param>
        /// <param name="metadata">
        /// When this method returns, contains <see langword="null"/>.
        /// </param>
        /// <returns>Always <see langword="false"/>.</returns>
        public override bool TryGetMetadata(string metadataName, out object? metadata)
        {
            metadata = default;

            return false;
        }
    }
}

