using AwesomeAssertions;

namespace DevElf.Tests;

[TestClass]
public class RoundRobinGeneratorBaseTests
{
    [TestMethod]
    public void NextValue_returns_start_when_start_equals_end()
    {
        // Arrange
        var sut = new IntRoundRobinGenerator(7, 7);

        // Act
        int result = sut.NextValue();

        // Assert
        _ = result.Should().Be(7);
    }

    [TestMethod]
    public void NextValue_cycles_through_range_and_wraps_to_start()
    {
        // Arrange
        var sut = new IntRoundRobinGenerator(2, 4);

        // Act
        int first = sut.NextValue();
        int second = sut.NextValue();
        int third = sut.NextValue();
        int fourth = sut.NextValue();
        int fifth = sut.NextValue();

        // Assert
        _ = first.Should().Be(2);
        _ = second.Should().Be(3);
        _ = third.Should().Be(4);
        _ = fourth.Should().Be(2);
        _ = fifth.Should().Be(3);
    }

    [TestMethod]
    public void Constructor_throws_when_start_greater_than_end()
    {
        // Arrange
        // Act
        var act = () => new IntRoundRobinGenerator(5, 2);

        // Assert
        _ = act.Should().Throw<ArgumentException>();
    }

    private class IntRoundRobinGenerator(int start, int end, IComparer<int>? comparer = null) : RoundRobinGeneratorBase<int>(start, end, comparer)
    {
        protected override int Increment(ref int value) => ++value;
    }
}
