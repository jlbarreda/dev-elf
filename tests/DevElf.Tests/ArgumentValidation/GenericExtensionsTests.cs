using AutoFixture;
using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class GenericExtensionsTests
{
    #region ThrowIfNull - Reference Types

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_non_null_reference_type()
    {
        // Arrange
        object sut = new();

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_reference_type()
    {
        // Arrange
        object? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_non_null_string()
    {
        // Arrange
        var fixture = new Fixture();
        string sut = fixture.Create<string>();

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_string()
    {
        // Arrange
        string? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_empty_string()
    {
        // Arrange
        string sut = string.Empty;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_custom_class()
    {
        // Arrange
        var sut = new CustomClass { Name = "Test" };

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_custom_class()
    {
        // Arrange
        CustomClass? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    #endregion

    #region ThrowIfNull - Nullable Value Types

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_int_with_value()
    {
        // Arrange
        int? sut = 42;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_int()
    {
        // Arrange
        int? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_bool_with_value()
    {
        // Arrange
        bool? sut = true;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_bool()
    {
        // Arrange
        bool? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_decimal_with_value()
    {
        // Arrange
        decimal? sut = 3.14m;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_decimal()
    {
        // Arrange
        decimal? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_DateTime_with_value()
    {
        // Arrange
        DateTime? sut = new DateTime(2023, 1, 1);

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_DateTime()
    {
        // Arrange
        DateTime? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_Guid_with_value()
    {
        // Arrange
        Guid? sut = Guid.NewGuid();

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_Guid()
    {
        // Arrange
        Guid? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_enum_with_value()
    {
        // Arrange
        TestEnum? sut = TestEnum.Value1;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_enum()
    {
        // Arrange
        TestEnum? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_struct_with_value()
    {
        // Arrange
        TestStruct? sut = new TestStruct { Value = 42 };

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_throws_ArgumentNullException_for_null_nullable_struct()
    {
        // Arrange
        TestStruct? sut = null;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    #endregion

    #region Boundary Values

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_int_with_zero_value()
    {
        // Arrange
        int? sut = 0;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_int_with_min_value()
    {
        // Arrange
        int? sut = int.MinValue;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_int_with_max_value()
    {
        // Arrange
        int? sut = int.MaxValue;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_double_with_positive_infinity()
    {
        // Arrange
        double? sut = double.PositiveInfinity;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_double_with_negative_infinity()
    {
        // Arrange
        double? sut = double.NegativeInfinity;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNull_does_not_throw_for_nullable_double_with_NaN()
    {
        // Arrange
        double? sut = double.NaN;

        // Act
        Action act = () => sut.ThrowIfNull();

        // Assert
        _ = act.Should().NotThrow();
    }

    #endregion

    #region Helper Types

    private class CustomClass
    {
        public string Name { get; set; } = string.Empty;
    }

    private enum TestEnum
    {
        Value1,
        Value2
    }

    private struct TestStruct
    {
        public int Value { get; set; }
    }

    #endregion
}
