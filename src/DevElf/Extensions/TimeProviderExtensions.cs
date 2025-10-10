using DevElf.ArgumentValidation;

namespace DevElf.Extensions;

/// <summary>
/// Extension methods for <see cref="TimeProvider"/> to provide convenient conversions and helpers.
/// </summary>
public static class TimeProviderExtensions
{
    /// <summary>
    /// Returns a <see cref="FrozenTimeProvider"/> that is frozen to the current instant of <paramref name="timeProvider"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>A frozen time provider.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static TimeProvider Freeze(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return new FrozenTimeProvider(timeProvider);
    }

    /// <summary>
    /// Returns the current local time from the provider as a <see cref="DateTime"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current local <see cref="DateTime"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static DateTime GetLocalNowAsDateTime(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetLocalNow().LocalDateTime;
    }

    /// <summary>
    /// Returns the current UTC time from the provider as a <see cref="DateTime"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current UTC <see cref="DateTime"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static DateTime GetUtcNowAsDateTime(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetUtcNow().UtcDateTime;
    }

    /// <summary>
    /// Returns the current local date from the provider as a <see cref="DateOnly"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current local <see cref="DateOnly"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static DateOnly GetToday(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetLocalNow().ToDateOnly();
    }

    /// <summary>
    /// Returns the current UTC date from the provider as a <see cref="DateOnly"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current UTC <see cref="DateOnly"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static DateOnly GetUtcToday(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetUtcNow().ToDateOnly();
    }

    /// <summary>
    /// Returns the current local time-of-day from the provider as a <see cref="TimeOnly"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current local <see cref="TimeOnly"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static TimeOnly GetTimeOfDay(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetLocalNow().TimeOfDayAsTimeOnly();
    }

    /// <summary>
    /// Returns the current UTC time-of-day from the provider as a <see cref="TimeOnly"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider.</param>
    /// <returns>The current UTC <see cref="TimeOnly"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public static TimeOnly GetUtcTimeOfDay(this TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        return timeProvider.GetUtcNow().TimeOfDayAsTimeOnly();
    }
}
