using AutoFixture;
using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class StringExtensionsTests
{
    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_when_string_is_not_empty()
    {
        // Arrange
        var fixture = new Fixture();
        string s = fixture.Create<string>();

        // Act
        Action act = () => s.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentNullException_when_string_is_null()
    {
        // Arrange
        string? value = null;

        // Act
        Action act = () => value.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentException_when_string_is_empty()
    {
        // Arrange
        string value = string.Empty;

        // Act
        Action act = () => value.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(value));
    }
}
