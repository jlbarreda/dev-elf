using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class ComparableExtensionsTests
{
    #region ThrowIfLessThan - Reference Types

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_value_is_greater_than_other()
    {
        // Arrange
        string value = "z";
        string other = "a";

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_value_equals_other()
    {
        // Arrange
        string value = "abc";
        string other = "abc";

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentOutOfRangeException_when_value_is_less_than_other()
    {
        // Arrange
        string value = "a";
        string other = "z";

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentNullException_when_value_is_null_and_throwIfNull_is_true()
    {
        // Arrange
        string? value = null;
        string other = "test";

        // Act
        Action act = () => value.ThrowIfLessThan(other, throwIfNull: true);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentNullException_when_other_is_null_and_throwIfNull_is_true()
    {
        // Arrange
        string value = "test";
        string? other = null;

        // Act
        Action act = () => value.ThrowIfLessThan(other, throwIfNull: true);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(other));
    }

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_value_is_null_and_throwIfNull_is_false()
    {
        // Arrange
        string? value = null;
        string other = "test";

        // Act
        Action act = () => value.ThrowIfLessThan(other, throwIfNull: false);

        // Assert
        _ = act.Should().NotThrow();
    }

    #endregion

    #region ThrowIfLessThan - Value Types

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_nullable_int_value_is_greater_than_other()
    {
        // Arrange
        int? value = 10;
        int? other = 5;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentOutOfRangeException_when_nullable_int_value_is_less_than_other()
    {
        // Arrange
        int? value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentNullException_when_nullable_value_is_null_and_throwIfNull_is_true()
    {
        // Arrange
        int? value = null;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfLessThan(other, throwIfNull: true);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfLessThanOrEqualTo - Reference Types

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_does_not_throw_when_value_is_greater_than_other()
    {
        // Arrange
        string value = "z";
        string other = "a";

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_throws_ArgumentOutOfRangeException_when_value_equals_other()
    {
        // Arrange
        string value = "abc";
        string other = "abc";

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_throws_ArgumentOutOfRangeException_when_value_is_less_than_other()
    {
        // Arrange
        string value = "a";
        string other = "z";

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThan - Reference Types

    [TestMethod]
    public void ThrowIfGreaterThan_does_not_throw_when_value_is_less_than_other()
    {
        // Arrange
        string value = "a";
        string other = "z";

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_does_not_throw_when_value_equals_other()
    {
        // Arrange
        string value = "abc";
        string other = "abc";

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_throws_ArgumentOutOfRangeException_when_value_is_greater_than_other()
    {
        // Arrange
        string value = "z";
        string other = "a";

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThan - Value Types

    [TestMethod]
    public void ThrowIfGreaterThan_does_not_throw_when_nullable_int_value_is_less_than_other()
    {
        // Arrange
        int? value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_throws_ArgumentOutOfRangeException_when_nullable_int_value_is_greater_than_other()
    {
        // Arrange
        int? value = 10;
        int? other = 5;

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThanOrEqualTo - Reference Types

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_does_not_throw_when_value_is_less_than_other()
    {
        // Arrange
        string value = "a";
        string other = "z";

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_value_equals_other()
    {
        // Arrange
        string value = "abc";
        string other = "abc";

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_value_is_greater_than_other()
    {
        // Arrange
        string value = "z";
        string other = "a";

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThanOrEqualTo - Value Types

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_does_not_throw_when_nullable_int_value_is_less_than_other()
    {
        // Arrange
        int? value = 5;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_int_value_equals_other()
    {
        // Arrange
        int? value = 10;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_int_value_is_greater_than_other()
    {
        // Arrange
        int? value = 15;
        int? other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region Mixed Type Tests

    [TestMethod]
    public void ThrowIfLessThan_works_with_DateTime()
    {
        // Arrange
        DateTime value = new(2023, 1, 1);
        DateTime other = new(2024, 1, 1);

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfGreaterThan_works_with_decimal()
    {
        // Arrange
        decimal value = 10.5m;
        decimal other = 5.2m;

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfLessThan - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_nullable_value_is_greater_than_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 5;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentOutOfRangeException_when_nullable_value_is_less_than_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentNullException_for_nullable_value_when_throwIfNull_is_true()
    {
        // Arrange
        int? value = null;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfLessThan(other, throwIfNull: true);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfLessThanOrEqualTo - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_does_not_throw_when_nullable_value_is_greater_than_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 5;

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_value_equals_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_value_is_less_than_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThan - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfGreaterThan_does_not_throw_when_nullable_value_is_less_than_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_throws_ArgumentOutOfRangeException_when_nullable_value_is_greater_than_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 5;

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThanOrEqualTo - Mixed Nullable and Non-Nullable

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_does_not_throw_when_nullable_value_is_less_than_non_nullable_other()
    {
        // Arrange
        int? value = 5;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_value_equals_non_nullable_other()
    {
        // Arrange
        int? value = 10;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_throws_ArgumentOutOfRangeException_when_nullable_value_is_greater_than_non_nullable_other()
    {
        // Arrange
        int? value = 15;
        int other = 10;

        // Act
        Action act = () => value.ThrowIfGreaterThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfLessThan - Boundary Values

    [TestMethod]
    public void ThrowIfLessThan_does_not_throw_when_value_is_int_MaxValue_and_other_is_int_MinValue()
    {
        // Arrange
        int value = int.MaxValue;
        int other = int.MinValue;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_throws_ArgumentOutOfRangeException_when_value_is_int_MinValue_and_other_is_int_MaxValue()
    {
        // Arrange
        int value = int.MinValue;
        int other = int.MaxValue;

        // Act
        Action act = () => value.ThrowIfLessThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfLessThanOrEqualTo - Boundary Values

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_does_not_throw_when_value_is_DateTime_MaxValue_and_other_is_DateTime_MinValue()
    {
        // Arrange
        DateTime value = DateTime.MaxValue;
        DateTime other = DateTime.MinValue;

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_throws_ArgumentOutOfRangeException_when_value_is_DateTime_MinValue_and_other_is_DateTime_MaxValue()
    {
        // Arrange
        DateTime value = DateTime.MinValue;
        DateTime other = DateTime.MaxValue;

        // Act
        Action act = () => value.ThrowIfLessThanOrEqualTo(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion

    #region ThrowIfGreaterThan - Custom Comparables

    private class CustomComparable : IComparable<CustomComparable>
    {
        public int Value { get; set; }

        public int CompareTo(CustomComparable? other)
        {
            if (other == null)
            {
                return 1;
            }

            return Value.CompareTo(other.Value);
        }
    }

    [TestMethod]
    public void ThrowIfGreaterThan_does_not_throw_for_custom_comparable_when_value_is_less_than_other()
    {
        // Arrange
        var value = new CustomComparable { Value = 5 };
        var other = new CustomComparable { Value = 10 };

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_throws_ArgumentOutOfRangeException_for_custom_comparable_when_value_is_greater_than_other()
    {
        // Arrange
        var value = new CustomComparable { Value = 10 };
        var other = new CustomComparable { Value = 5 };

        // Act
        Action act = () => value.ThrowIfGreaterThan(other);

        // Assert
        _ = act.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(value));
    }

    #endregion
}
