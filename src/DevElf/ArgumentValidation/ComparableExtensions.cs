using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides extension methods for validating comparable arguments.
/// </summary>
public static class ComparableExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IComparable<T>
    {
        if (value is not null && other is not null && value.CompareTo(other) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && value.Value.CompareTo(other) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (other.HasValue && value.CompareTo(other.Value) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IComparable<T>
    {
        if (value is not null && other is not null && value.CompareTo(other) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && value.Value.CompareTo(other) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (other.HasValue && value.CompareTo(other.Value) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be greater than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IComparable<T>
    {
        if (value is not null && other is not null && value.CompareTo(other) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && value.Value.CompareTo(other) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (other.HasValue && value.CompareTo(other.Value) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than or equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IComparable<T>
    {
        if (value is not null && other is not null && value.CompareTo(other) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (value.HasValue && value.Value.CompareTo(other) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IComparable<T>
    {
        if (other.HasValue && value.CompareTo(other.Value) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must be less than '{other}'.");
        }
    }
}
