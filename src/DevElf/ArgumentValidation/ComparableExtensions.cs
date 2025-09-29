using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides extension methods for validating comparable arguments.
/// </summary>
public static class ComparableExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : IComparable<T>
    {
        if (throwIfNull)
        {
            ArgumentNullException.ThrowIfNull(value, parameterName);
            ArgumentNullException.ThrowIfNull(other, otherParameterName);
        }

        if (value is not null && other is not null && value.CompareTo(other) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull)
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (!other.HasValue)
            {
                throw new ArgumentNullException(otherParameterName);
            }
        }

        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="value"/> is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="value"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T? value,
        T other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !value.HasValue)
        {
            throw new ArgumentNullException(parameterName);
        }

        if (value.HasValue && value.Value.CompareTo(other) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="throwIfNull"/> is <see langword="true"/> and
    /// if <paramref name="other"/> is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="other"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than <paramref name="other"/>.</exception>
    public static void ThrowIfLessThan<T>(
        this T value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !other.HasValue)
        {
            throw new ArgumentNullException(otherParameterName);
        }

        if (other.HasValue && value.CompareTo(other.Value) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : IComparable<T>
    {
        if (throwIfNull)
        {
            ArgumentNullException.ThrowIfNull(value, parameterName);
            ArgumentNullException.ThrowIfNull(other, otherParameterName);
        }

        if (value is not null && other is not null && value.CompareTo(other) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull)
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (!other.HasValue)
            {
                throw new ArgumentNullException(otherParameterName);
            }
        }

        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="value"/> is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="value"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T? value,
        T other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !value.HasValue)
        {
            throw new ArgumentNullException(parameterName);
        }

        if (value.HasValue && value.Value.CompareTo(other) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="throwIfNull"/> is <see langword="true"/> and
    /// if <paramref name="other"/> is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="other"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is less than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfLessThanOrEqualTo<T>(
        this T value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !other.HasValue)
        {
            throw new ArgumentNullException(otherParameterName);
        }

        if (other.HasValue && value.CompareTo(other.Value) <= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : IComparable<T>
    {
        if (throwIfNull)
        {
            ArgumentNullException.ThrowIfNull(value, parameterName);
            ArgumentNullException.ThrowIfNull(other, otherParameterName);
        }

        if (value is not null && other is not null && value.CompareTo(other) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull)
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (!other.HasValue)
            {
                throw new ArgumentNullException(otherParameterName);
            }
        }

        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="value"/> is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="value"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T? value,
        T other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !value.HasValue)
        {
            throw new ArgumentNullException(parameterName);
        }

        if (value.HasValue && value.Value.CompareTo(other) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="throwIfNull"/> is <see langword="true"/> and
    /// if <paramref name="other"/> is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="other"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThan<T>(
        this T value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !other.HasValue)
        {
            throw new ArgumentNullException(otherParameterName);
        }

        if (other.HasValue && value.CompareTo(other.Value) > 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : IComparable<T>
    {
        if (throwIfNull)
        {
            ArgumentNullException.ThrowIfNull(value, parameterName);
            ArgumentNullException.ThrowIfNull(other, otherParameterName);
        }

        if (value is not null && other is not null && value.CompareTo(other) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and either argument is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull)
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (!other.HasValue)
            {
                throw new ArgumentNullException(otherParameterName);
            }
        }

        if (value.HasValue && other.HasValue && value.Value.CompareTo(other.Value) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="value"/> is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="value"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="value"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T? value,
        T other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !value.HasValue)
        {
            throw new ArgumentNullException(parameterName);
        }

        if (value.HasValue && value.Value.CompareTo(other) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal to <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if <paramref name="throwIfNull"/> is <see langword="true"/> and
    /// if <paramref name="other"/> is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If <see langword="true"/>, throws if <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and <paramref name="other"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is greater than or equal to <paramref name="other"/>.</exception>
    public static void ThrowIfGreaterThanOrEqualTo<T>(
        this T value,
        T? other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : struct, IComparable<T>
    {
        if (throwIfNull && !other.HasValue)
        {
            throw new ArgumentNullException(otherParameterName);
        }

        if (other.HasValue && value.CompareTo(other.Value) >= 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be less than '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }
}
