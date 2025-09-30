using AutoFixture;
using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class NumberBaseExtensionsTests
{
    [TestMethod]
    public void ThrowIfNegative_should_throw_ArgumentOutOfRangeException_when_value_is_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfNegative();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegative_should_not_throw_when_value_is_not_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfNegative();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegative_should_throw_ArgumentOutOfRangeException_when_nullable_value_is_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfNegative();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegative_should_not_throw_when_nullable_value_is_not_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfNegative();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegative_should_not_throw_when_nullable_value_is_null()
    {
        // Arrange
        int? value = null;

        // Act
        var act = () => value.ThrowIfNegative();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_throw_ArgumentOutOfRangeException_when_value_is_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_throw_ArgumentOutOfRangeException_when_value_is_zero()
    {
        // Arrange
        int value = 0;

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_not_throw_when_value_is_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_throw_ArgumentOutOfRangeException_when_nullable_value_is_negative()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_throw_ArgumentOutOfRangeException_when_nullable_value_is_zero()
    {
        // Arrange
        int? value = 0;

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_not_throw_when_nullable_value_is_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_should_not_throw_when_nullable_value_is_null()
    {
        // Arrange
        int? value = null;

        // Act
        var act = () => value.ThrowIfNegativeOrZero();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositive_should_throw_ArgumentOutOfRangeException_when_value_is_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfPositive();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfPositive_should_not_throw_when_value_is_not_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfPositive();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositive_should_throw_ArgumentOutOfRangeException_when_nullable_value_is_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfPositive();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfPositive_should_not_throw_when_nullable_value_is_not_positive()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>() * -1;

        // Act
        var act = () => value.ThrowIfPositive();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositive_should_not_throw_when_nullable_value_is_null()
    {
        // Arrange
        int? value = null;

        // Act
        var act = () => value.ThrowIfPositive();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfZero_should_throw_ArgumentOutOfRangeException_when_value_is_zero()
    {
        // Arrange
        int value = 0;

        // Act
        var act = () => value.ThrowIfZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfZero_should_not_throw_when_value_is_not_zero()
    {
        // Arrange
        var fixture = new Fixture();
        int value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfZero();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfZero_should_throw_ArgumentOutOfRangeException_when_nullable_value_is_zero()
    {
        // Arrange
        int? value = 0;

        // Act
        var act = () => value.ThrowIfZero();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void ThrowIfZero_should_not_throw_when_nullable_value_is_not_zero()
    {
        // Arrange
        var fixture = new Fixture();
        int? value = fixture.Create<int>();

        // Act
        var act = () => value.ThrowIfZero();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfZero_should_not_throw_when_nullable_value_is_null()
    {
        // Arrange
        int? value = null;

        // Act
        var act = () => value.ThrowIfZero();

        // Assert
        _ = act.Should().NotThrow();
    }
}
