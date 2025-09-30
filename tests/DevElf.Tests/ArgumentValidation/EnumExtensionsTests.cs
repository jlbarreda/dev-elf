using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class EnumExtensionsTests
{
    private enum TestEnum
    {
        A = 0,
        B = 1,
    }

    [TestMethod]
    public void ThrowIfNotDefined_does_not_throw_for_defined_value()
    {
        // Arrange
        TestEnum sut = TestEnum.A;

        // Act
        Action act = () => sut.ThrowIfNotDefined();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotDefined_throws_for_undefined_value()
    {
        // Arrange
        var sut = (TestEnum)999;

        // Act
        Action act = () => sut.ThrowIfNotDefined();

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(sut));
    }
}
