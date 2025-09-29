using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides extension methods for <see cref="IEquatable{T}"/> types.
/// </summary>
public static class EquatableExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfEqual<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IEquatable<T>
    {
        if (value?.Equals(other) is true)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must not be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfEqual<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if ((!value.HasValue && !other.HasValue) || (value.HasValue && other.HasValue && value.Value.Equals(other.Value)))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must not be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfEqual<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if (value.HasValue && value.Value.Equals(other))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must not be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfEqual<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if (other.HasValue && value.Equals(other.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must not be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// not equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is not equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfNotEqual<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : IEquatable<T>
    {
        if (value is null && other is null)
        {
            return;
        }

        if (value is null || other is null || !value.Equals(other))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// not equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is not equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfNotEqual<T>(
        this T? value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if (!value.HasValue && !other.HasValue)
        {
            return;
        }

        if (!value.HasValue || !other.HasValue || !value.Value.Equals(other.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// not equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is not equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfNotEqual<T>(
        this T? value,
        T other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if (!value.HasValue || !value.Value.Equals(other))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must be equal to '{other}'.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified <paramref name="value"/> is
    /// not equal to <paramref name="other"/>.
    /// </summary>
    /// <typeparam name="T">The type of the objects to compare.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="parameterName">The name of the parameter being checked.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is not equal to <paramref name="other"/>.
    /// </exception>
    public static void ThrowIfNotEqual<T>(
        this T value,
        T? other,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, IEquatable<T>
    {
        if (!other.HasValue || !value.Equals(other.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' must be equal to '{other}'.");
        }
    }
}
