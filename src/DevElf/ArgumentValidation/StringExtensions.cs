using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides extension helpers for validating <see cref="string"/> arguments.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> when <paramref name="argument"/>
    /// is <see langword="null"/> or an empty string.
    /// </summary>
    /// <param name="argument">The string to validate.</param>
    /// <param name="parameterName">
    /// The name of the parameter. This is supplied automatically by the compiler
    /// when the method is used as an extension method because of the
    /// <see cref="CallerArgumentExpressionAttribute"/> on this parameter.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="argument"/> is <see langword="null"/> or empty.
    /// </exception>
    public static void ThrowIfNullOrEmpty(
        [NotNull] this string? argument,
        [CallerArgumentExpression(nameof(argument))] string parameterName = null!)
            => ArgumentNullException.ThrowIfNullOrEmpty(argument, parameterName);
}
