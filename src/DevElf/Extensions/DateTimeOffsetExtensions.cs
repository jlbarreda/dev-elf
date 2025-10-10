namespace DevElf.Extensions;

/// <summary>
/// Extension helpers for <see cref="DateTimeOffset"/> conversions to <see cref="DateOnly"/> and <see cref="TimeOnly"/>.
/// </summary>
public static class DateTimeOffsetExtensions
{
    /// <summary>
    /// Returns the date component of the provided <see cref="DateTimeOffset"/> as a <see cref="DateOnly"/>.
    /// The date portion is taken from the <see cref="DateTimeOffset.Date"/> property.
    /// </summary>
    public static DateOnly ToDateOnly(this DateTimeOffset dateTimeOffset)
        => DateOnly.FromDateTime(dateTimeOffset.Date);

    /// <summary>
    /// Returns the local date component of the provided <see cref="DateTimeOffset"/> as a <see cref="DateOnly"/>.
    /// </summary>
    public static DateOnly ToLocalDateOnly(this DateTimeOffset dateTimeOffset)
        => DateOnly.FromDateTime(dateTimeOffset.LocalDateTime);

    /// <summary>
    /// Returns the UTC date component of the provided <see cref="DateTimeOffset"/> as a <see cref="DateOnly"/>.
    /// </summary>
    public static DateOnly ToUtcDateOnly(this DateTimeOffset dateTimeOffset)
        => DateOnly.FromDateTime(dateTimeOffset.UtcDateTime);

    /// <summary>
    /// Returns the time-of-day component as a <see cref="TimeOnly"/>.
    /// This represents the time portion in the offset's time zone.
    /// </summary>
    public static TimeOnly TimeOfDayAsTimeOnly(this DateTimeOffset dateTimeOffset)
        => TimeOnly.FromTimeSpan(dateTimeOffset.TimeOfDay);

    /// <summary>
    /// Returns the local time-of-day component as a <see cref="TimeOnly"/>.
    /// </summary>
    public static TimeOnly LocalTimeOfDayAsTimeOnly(this DateTimeOffset dateTimeOffset)
        => TimeOnly.FromTimeSpan(dateTimeOffset.LocalDateTime.TimeOfDay);
}
