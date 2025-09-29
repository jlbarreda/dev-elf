using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class EquatableExtensionsTests
{
    #region ThrowIfEqual - Reference Types

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_reference_values_are_different()
    {
        // Arrange
        string value = "abc";
        string other = "def";

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_value_is_null_and_other_is_not_null()
    {
        // Arrange
        string? value = null;
        string other = "test";

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_value_is_not_null_and_other_is_null()
    {
        // Arrange
        string value = "test";
        string? other = null;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_when_reference_values_are_equal()
    {
        // Arrange
        string value = "test";
        string other = "test";

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfEqual - Value Types (Nullable)

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_nullable_values_are_different()
    {
        // Arrange
        int? value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_nullable_value_is_null_and_other_has_value()
    {
        // Arrange
        int? value = null;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_nullable_value_has_value_and_other_is_null()
    {
        // Arrange
        int? value = 10;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_when_nullable_values_are_equal()
    {
        // Arrange
        int? value = 10;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_when_both_nullable_values_are_null()
    {
        // Arrange
        int? value = null;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfEqual - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_nullable_value_is_null_and_other_is_non_nullable()
    {
        // Arrange
        int? value = null;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_nullable_value_is_different_from_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_when_nullable_value_equals_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_non_nullable_value_is_different_from_nullable_other()
    {
        // Arrange
        int value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_when_non_nullable_value_and_nullable_other_is_null()
    {
        // Arrange
        int value = 10;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_when_non_nullable_value_equals_nullable_other()
    {
        // Arrange
        int value = 10;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfNotEqual - Reference Types

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_reference_values_are_equal()
    {
        // Arrange
        string value = "test";
        string other = "test";

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_both_reference_values_are_null()
    {
        // Arrange
        string? value = null;
        string? other = null;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_reference_values_are_different()
    {
        // Arrange
        string value = "abc";
        string other = "def";

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_value_is_null_and_other_is_not_null()
    {
        // Arrange
        string? value = null;
        string other = "test";

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_value_is_not_null_and_other_is_null()
    {
        // Arrange
        string value = "test";
        string? other = null;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfNotEqual - Value Types (Nullable)

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_nullable_values_are_equal()
    {
        // Arrange
        int? value = 10;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_both_nullable_values_are_null()
    {
        // Arrange
        int? value = null;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_values_are_different()
    {
        // Arrange
        int? value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_value_is_null_and_other_has_value()
    {
        // Arrange
        int? value = null;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_value_has_value_and_other_is_null()
    {
        // Arrange
        int? value = 10;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfNotEqual - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_nullable_value_equals_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_value_is_null()
    {
        // Arrange
        int? value = null;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_value_is_different_from_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_when_non_nullable_value_equals_nullable_other()
    {
        // Arrange
        int value = 10;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_nullable_other_is_null()
    {
        // Arrange
        int value = 10;
        int? other = null;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_when_non_nullable_value_is_different_from_nullable_other()
    {
        // Arrange
        int value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region Custom Equatable Types

    private class CustomEquatable : IEquatable<CustomEquatable>
    {
        public string Name { get; set; } = string.Empty;

        public int Id { get; set; }

        public bool Equals(CustomEquatable? other) => other is not null && Name == other.Name && Id == other.Id;

        public override bool Equals(object? obj) => Equals(obj as CustomEquatable);

        public override int GetHashCode() => HashCode.Combine(Name, Id);

        public override string ToString() => $"{Name}({Id})";
    }

    [TestMethod]
    public void ThrowIfEqual_does_not_throw_for_custom_equatable_when_values_are_different()
    {
        // Arrange
        var value = new CustomEquatable { Name = "Test", Id = 1 };
        var other = new CustomEquatable { Name = "Test", Id = 2 };

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_throws_ArgumentOutOfRangeException_for_custom_equatable_when_values_are_equal()
    {
        // Arrange
        var value = new CustomEquatable { Name = "Test", Id = 1 };
        var other = new CustomEquatable { Name = "Test", Id = 1 };

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_for_custom_equatable_when_values_are_equal()
    {
        // Arrange
        var value = new CustomEquatable { Name = "Test", Id = 1 };
        var other = new CustomEquatable { Name = "Test", Id = 1 };

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNotEqual_throws_ArgumentOutOfRangeException_for_custom_equatable_when_values_are_different()
    {
        // Arrange
        var value = new CustomEquatable { Name = "Test", Id = 1 };
        var other = new CustomEquatable { Name = "Test", Id = 2 };

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region Built-in Types

    [TestMethod]
    public void ThrowIfEqual_works_with_DateTime()
    {
        // Arrange
        DateTime value = new(2023, 1, 1);
        DateTime other = new(2023, 1, 1);

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfEqual_works_with_Guid()
    {
        // Arrange
        Guid value = Guid.Parse("12345678-1234-1234-1234-123456789abc");
        Guid other = Guid.Parse("12345678-1234-1234-1234-123456789abc");

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_works_with_decimal()
    {
        // Arrange
        decimal value = 10.5m;
        decimal other = 5.2m;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_works_with_bool()
    {
        // Arrange
        bool value = true;
        bool other = false;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region Boundary Values

    [TestMethod]
    public void ThrowIfEqual_works_with_boundary_values()
    {
        // Arrange
        int value = int.MaxValue;
        int other = int.MaxValue;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_with_boundary_values()
    {
        // Arrange
        long value = long.MinValue;
        long other = long.MinValue;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    #endregion

    #region Error Message Validation

    [TestMethod]
    public void ThrowIfEqual_exception_contains_correct_message()
    {
        // Arrange
        string value = "test";
        string other = "test";

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("'value' must not be equal to 'test'.*");
    }

    [TestMethod]
    public void ThrowIfNotEqual_exception_contains_correct_message()
    {
        // Arrange
        string value = "abc";
        string other = "def";

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("'value' must be equal to 'def'.*");
    }

    #endregion

    #region Special Cases

    [TestMethod]
    public void ThrowIfEqual_works_with_empty_strings()
    {
        // Arrange
        string value = string.Empty;
        string other = string.Empty;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfNotEqual_does_not_throw_with_empty_strings()
    {
        // Arrange
        string value = string.Empty;
        string other = string.Empty;

        // Act
        Action act = () => value.ThrowIfNotEqual(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfEqual_works_with_zero_values()
    {
        // Arrange
        double value = 0.0;
        double other = 0.0;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfEqual_works_with_negative_zero()
    {
        // Arrange
        double value = -0.0;
        double other = 0.0;

        // Act
        Action act = () => value.ThrowIfEqual(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion
}
