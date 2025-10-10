using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class TimeProviderExtensionsTests
{
    [TestMethod]
    public void FrozenTimeProvider_GetUtcNow_returns_utc_instant()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 12, 0, 0, TimeSpan.FromHours(2));

        // Act
        var frozen = new FrozenTimeProvider(dto);

        // Assert
        _ = frozen.GetUtcNow().Should().Be(dto.ToUniversalTime());
    }

    [TestMethod]
    public void Freeze_returns_frozen_provider_with_same_utc()
    {
        // Arrange
        var dto = new DateTimeOffset(2023, 1, 2, 3, 4, 5, TimeSpan.Zero);
        var frozen = new FrozenTimeProvider(dto);

        // Act
        var frozen2 = frozen.Freeze();

        // Assert
        _ = frozen2.GetUtcNow().Should().Be(frozen.GetUtcNow());
    }

    [TestMethod]
    public void GetUtcNowAsDateTime_returns_utc_date_time()
    {
        // Arrange
        var dto = new DateTimeOffset(2024, 6, 7, 8, 9, 10, TimeSpan.FromHours(-4));
        var frozen = new FrozenTimeProvider(dto);

        // Act
        var result = frozen.GetUtcNowAsDateTime();

        // Assert
        _ = result.Should().Be(frozen.GetUtcNow().UtcDateTime);
    }

    [TestMethod]
    public void GetLocalNowAsDateTime_returns_local_date_time()
    {
        // Arrange
        var dto = new DateTimeOffset(2022, 12, 31, 23, 0, 0, TimeSpan.FromHours(1));
        var frozen = new FrozenTimeProvider(dto);

        // Act
        var result = frozen.GetLocalNowAsDateTime();

        // Assert
        _ = result.Should().Be(frozen.GetLocalNow().LocalDateTime);
    }

    [TestMethod]
    public void GetToday_and_GetUtcToday_and_time_of_day_methods_return_expected_values()
    {
        // Arrange
        var dto = new DateTimeOffset(2025, 4, 5, 18, 45, 30, TimeSpan.FromHours(2));
        var frozen = new FrozenTimeProvider(dto);

        // Act
        var today = frozen.GetToday();
        var utcToday = frozen.GetUtcToday();
        var timeOfDay = frozen.GetTimeOfDay();
        var utcTimeOfDay = frozen.GetUtcTimeOfDay();

        // Assert
        _ = today.Should().Be(DateOnly.FromDateTime(frozen.GetLocalNow().LocalDateTime));
        _ = utcToday.Should().Be(DateOnly.FromDateTime(frozen.GetUtcNow().UtcDateTime));
        _ = timeOfDay.Should().Be(TimeOnly.FromTimeSpan(frozen.GetLocalNow().TimeOfDay));
        _ = utcTimeOfDay.Should().Be(TimeOnly.FromTimeSpan(frozen.GetUtcNow().TimeOfDay));
    }

    [TestMethod]
    public void Freeze_throws_ArgumentNullException_when_timeProvider_is_null()
    {
        // Arrange
        TimeProvider? timeProvider = null;

        // Act
        Action act = () => timeProvider!.Freeze();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }
}
