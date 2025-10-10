using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class DateTimeOffsetExtensionsTests
{
    [TestMethod]
    public void ToDateOnly_returns_date_component()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 13, 30, 0, TimeSpan.FromHours(2));

        // Act
        var result = dto.ToDateOnly();

        // Assert
        _ = result.Year.Should().Be(2025);
        _ = result.Month.Should().Be(4);
        _ = result.Day.Should().Be(5);
    }

    [TestMethod]
    public void ToLocalDateOnly_returns_local_date_component()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 23, 0, 0, TimeSpan.FromHours(3));

        // Act
        var result = dto.ToLocalDateOnly();

        // Assert
        _ = result.Should().Be(DateOnly.FromDateTime(dto.LocalDateTime));
    }

    [TestMethod]
    public void ToUtcDateOnly_returns_utc_date_component()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 23, 0, 0, TimeSpan.FromHours(3));

        // Act
        var result = dto.ToUtcDateOnly();

        // Assert
        _ = result.Should().Be(DateOnly.FromDateTime(dto.UtcDateTime));
    }

    [TestMethod]
    public void TimeOfDayAsTimeOnly_returns_time_of_day()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 6, 7, 8, TimeSpan.FromHours(-5));

        // Act
        var result = dto.TimeOfDayAsTimeOnly();

        // Assert
        _ = result.Should().Be(TimeOnly.FromTimeSpan(dto.TimeOfDay));
    }

    [TestMethod]
    public void LocalTimeOfDayAsTimeOnly_returns_local_time_of_day()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 18, 30, 0, TimeSpan.FromHours(1));

        // Act
        var result = dto.LocalTimeOfDayAsTimeOnly();

        // Assert
        _ = result.Should().Be(TimeOnly.FromTimeSpan(dto.LocalDateTime.TimeOfDay));
    }

    [TestMethod]
    public void ToDateOnly_and_ToUtcDateOnly_do_not_convert_each_other_when_offset_changes_day()
    {
        // Arrange: choose a local date/time that when converted to UTC falls on the previous day
        var dto = new DateTimeOffset(2025, 4, 5, 0, 30, 0, TimeSpan.FromHours(3));

        // Act
        var localDate = dto.ToDateOnly();
        var utcDate = dto.ToUtcDateOnly();

        // Assert: the two dates should be distinct and reflect the offset semantics
        _ = localDate.Should().Be(DateOnly.FromDateTime(dto.Date));
        _ = utcDate.Should().Be(DateOnly.FromDateTime(dto.UtcDateTime));
        _ = localDate.Should().NotBe(utcDate);
    }

    [TestMethod]
    public void TimeOfDayAsTimeOnly_is_not_converted_to_utc_time_of_day()
    {
        // Arrange: choose an offseted time where UTC time-of-day differs
        var dto = new DateTimeOffset(2025, 4, 5, 1, 15, 0, TimeSpan.FromHours(5));

        // Act
        var localTimeOnly = dto.TimeOfDayAsTimeOnly();
        var utcTimeOnly = TimeOnly.FromTimeSpan(dto.UtcDateTime.TimeOfDay);

        // Assert: local time-of-day reflects the offset's time, not UTC
        _ = localTimeOnly.Should().Be(TimeOnly.FromTimeSpan(dto.TimeOfDay));
        _ = localTimeOnly.Should().NotBe(utcTimeOnly);
    }

    [TestMethod]
    public void ToLocalDateOnly_differs_from_ToDateOnly_when_system_timezone_differs_from_offset()
    {
        // Arrange: create a DateTimeOffset with an offset different from the system's local time
        // using a positive offset that would differ from most system timezones
        var dto = new DateTimeOffset(2025, 4, 5, 12, 0, 0, DateTimeOffset.Now.Offset + TimeSpan.FromHours(2));

        // Act
        var dateOnly = dto.ToDateOnly();
        var localDateOnly = dto.ToLocalDateOnly();

        // Assert: ToDateOnly uses the offset's date, ToLocalDateOnly converts to system local time
        _ = dateOnly.Should().Be(DateOnly.FromDateTime(dto.Date));
        _ = localDateOnly.Should().Be(DateOnly.FromDateTime(dto.LocalDateTime));
    }
}
