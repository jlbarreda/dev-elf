using AutoFixture;
using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class StringExtensionsTests
{
    [TestMethod]
    public void ThrowIfNullOrEmpty_DoesNotThrow_ForNonEmpty()
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
    public void ThrowIfNullOrEmpty_ThrowsArgumentNullException_ForNull()
    {
        // Arrange
        var fixture = new Fixture();
        string? value = null;

        // Act
        Action act = () => value.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_ThrowsArgumentException_ForEmpty()
    {
        // Arrange
        var fixture = new Fixture();
        string value = string.Empty;

        // Act
        Action act = () => value.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(value));
    }
}
