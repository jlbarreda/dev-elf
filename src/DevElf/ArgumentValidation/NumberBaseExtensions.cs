using System.Numerics;
using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides extension methods for validating arguments of type <see cref="INumberBase{T}"/>.
/// </summary>
public static class NumberBaseExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is negative.
    /// </summary>
    /// <typeparam name="T">The type of the value to check, which must implement <see cref="INumberBase{T}"/>.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is negative.
    /// </exception>
    public static void ThrowIfNegative<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : INumberBase<T>
    {
        if (value is not null && T.IsNegative(value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be negative.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is negative.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to check, which must be a struct and implement <see cref="INumberBase{T}"/>.
    /// </typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is negative.
    /// </exception>
    public static void ThrowIfNegative<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, INumberBase<T>
    {
        if (value is not null && T.IsNegative(value.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be negative.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is negative or zero.
    /// </summary>
    /// <typeparam name="T">The type of the value to check, which must implement <see cref="INumberBase{T}"/>.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is negative or zero.
    /// </exception>
    public static void ThrowIfNegativeOrZero<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : INumberBase<T>
    {
        if (value is not null && (T.IsNegative(value) || T.IsZero(value)))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be negative or zero.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is negative or zero.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to check, which must be a struct and implement <see cref="INumberBase{T}"/>.
    /// </typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is negative or zero.
    /// </exception>
    public static void ThrowIfNegativeOrZero<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, INumberBase<T>
    {
        if (value is not null && (T.IsNegative(value.Value) || T.IsZero(value.Value)))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be negative or zero.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is positive.
    /// </summary>
    /// <typeparam name="T">The type of the value to check, which must implement <see cref="INumberBase{T}"/>.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is positive.
    /// </exception>
    public static void ThrowIfPositive<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : INumberBase<T>
    {
        if (value is not null && T.IsPositive(value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be positive.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is positive.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to check, which must be a struct and implement <see cref="INumberBase{T}"/>.
    /// </typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is positive.
    /// </exception>
    public static void ThrowIfPositive<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, INumberBase<T>
    {
        if (value is not null && T.IsPositive(value.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be positive.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is zero.
    /// </summary>
    /// <typeparam name="T">The type of the value to check, which must implement <see cref="INumberBase{T}"/>.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is zero.
    /// </exception>
    public static void ThrowIfZero<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : INumberBase<T>
    {
        if (value is not null && T.IsZero(value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be zero.");
        }
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified value is zero.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to check, which must be a struct and implement <see cref="INumberBase{T}"/>.
    /// </typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="parameterName">
    /// The name of the parameter being checked. This is automatically captured from the expression
    /// passed as the <paramref name="value"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the <paramref name="value"/> is zero.
    /// </exception>
    public static void ThrowIfZero<T>(
        this T? value,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!)
        where T : struct, INumberBase<T>
    {
        if (value is not null && T.IsZero(value.Value))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                value,
                $"'{parameterName}' ('{value}') must not be zero.");
        }
    }
}
