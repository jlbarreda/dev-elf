using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class GenericExtensionsTests
{
    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_non_null()
    {
        // Arrange
        object sut = new();

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_for_null()
    {
        // Arrange
        object? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }
}
