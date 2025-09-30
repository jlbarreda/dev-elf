using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class EnumExtensionsTests
{
    private enum TestEnum
    {
        A = 0,
        B = 1,
        C = 2,
    }

    [Flags]
    private enum FlagsTestEnum
    {
        None = 0,
        Flag1 = 1,
        Flag2 = 2,
        Flag3 = 4,
        Combined = Flag1 | Flag2,
    }

    [TestMethod]
    public void IsDefined_returns_true_for_defined_enum_value()
    {
        // Arrange
        TestEnum sut = TestEnum.A;

        // Act
        bool result = sut.IsDefined();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsDefined_returns_true_for_all_defined_enum_values()
    {
        // Arrange & Act & Assert
        _ = TestEnum.A.IsDefined().Should().BeTrue();
        _ = TestEnum.B.IsDefined().Should().BeTrue();
        _ = TestEnum.C.IsDefined().Should().BeTrue();
    }

    [TestMethod]
    public void IsDefined_returns_false_for_undefined_enum_value()
    {
        // Arrange
        var sut = (TestEnum)999;

        // Act
        bool result = sut.IsDefined();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsDefined_returns_false_for_negative_undefined_enum_value()
    {
        // Arrange
        var sut = (TestEnum)(-1);

        // Act
        bool result = sut.IsDefined();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsDefined_returns_true_for_defined_flags_enum_individual_values()
    {
        // Arrange & Act & Assert
        _ = FlagsTestEnum.None.IsDefined().Should().BeTrue();
        _ = FlagsTestEnum.Flag1.IsDefined().Should().BeTrue();
        _ = FlagsTestEnum.Flag2.IsDefined().Should().BeTrue();
        _ = FlagsTestEnum.Flag3.IsDefined().Should().BeTrue();
        _ = FlagsTestEnum.Combined.IsDefined().Should().BeTrue();
    }

    [TestMethod]
    public void IsDefined_returns_false_for_combined_flags_enum_values_not_explicitly_defined()
    {
        // Arrange
        var sut = FlagsTestEnum.Flag1 | FlagsTestEnum.Flag3;

        // Act
        bool result = sut.IsDefined();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotDefined_returns_false_for_defined_enum_value()
    {
        // Arrange
        TestEnum sut = TestEnum.A;

        // Act
        bool result = sut.IsNotDefined();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotDefined_returns_false_for_all_defined_enum_values()
    {
        // Arrange & Act & Assert
        _ = TestEnum.A.IsNotDefined().Should().BeFalse();
        _ = TestEnum.B.IsNotDefined().Should().BeFalse();
        _ = TestEnum.C.IsNotDefined().Should().BeFalse();
    }

    [TestMethod]
    public void IsNotDefined_returns_true_for_undefined_enum_value()
    {
        // Arrange
        var sut = (TestEnum)999;

        // Act
        bool result = sut.IsNotDefined();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotDefined_returns_true_for_negative_undefined_enum_value()
    {
        // Arrange
        var sut = (TestEnum)(-1);

        // Act
        bool result = sut.IsNotDefined();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotDefined_returns_false_for_defined_flags_enum_individual_values()
    {
        // Arrange & Act & Assert
        _ = FlagsTestEnum.None.IsNotDefined().Should().BeFalse();
        _ = FlagsTestEnum.Flag1.IsNotDefined().Should().BeFalse();
        _ = FlagsTestEnum.Flag2.IsNotDefined().Should().BeFalse();
        _ = FlagsTestEnum.Flag3.IsNotDefined().Should().BeFalse();
        _ = FlagsTestEnum.Combined.IsNotDefined().Should().BeFalse();
    }

    [TestMethod]
    public void IsNotDefined_returns_true_for_combined_flags_enum_values_not_explicitly_defined()
    {
        // Arrange
        var sut = FlagsTestEnum.Flag1 | FlagsTestEnum.Flag3;

        // Act
        bool result = sut.IsNotDefined();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotDefined_returns_true_for_undefined_flags_enum_value()
    {
        // Arrange
        var sut = (FlagsTestEnum)999;

        // Act
        bool result = sut.IsNotDefined();

        // Assert
        _ = result.Should().BeTrue();
    }
}
