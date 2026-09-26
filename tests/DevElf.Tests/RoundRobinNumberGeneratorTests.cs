using System.Numerics;
using AwesomeAssertions;

namespace DevElf.Tests;

public class RoundRobinNumberGeneratorTests
{
    [Test]
    public void NextValue_returns_start_when_start_equals_end()
    {
        // Arrange
        var sut = new RoundRobinNumberGenerator<int>(5, 5);

        // Act
        int result = sut.NextValue();

        // Assert
        _ = result.Should().Be(5);
    }

    [Test]
    public void NextValue_cycles_through_range_and_wraps_to_start()
    {
        // Arrange
        var sut = new RoundRobinNumberGenerator<int>(1, 3);

        // Act
        int first = sut.NextValue();
        int second = sut.NextValue();
        int third = sut.NextValue();
        int fourth = sut.NextValue();
        int fifth = sut.NextValue();

        // Assert
        _ = first.Should().Be(1);
        _ = second.Should().Be(2);
        _ = third.Should().Be(3);
        _ = fourth.Should().Be(1);
        _ = fifth.Should().Be(2);
    }

    [Test]
    public void Constructor_throws_when_start_greater_than_end()
    {
        // Arrange
        // Act
        var act = () => new RoundRobinNumberGenerator<int>(10, 5);

        // Assert
        _ = act.Should().Throw<ArgumentException>();
    }
}
