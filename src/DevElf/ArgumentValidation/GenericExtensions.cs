using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides argument validation helpers for reference types and nullable value types.
/// </summary>
public static class GenericExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> when <paramref name="argument"/> is
    /// <see langword="null"/>. Applies to reference types.
    /// </summary>
    /// <typeparam name="T">The reference type of the argument to validate.</typeparam>
    /// <param name="argument">The argument to validate.</param>
    /// <param name="parameterName">
    /// The name of the parameter. This is supplied automatically by the compiler when the method
    /// is used as an extension method because of the <see cref="CallerArgumentExpressionAttribute"/>
    /// on this parameter.
    /// </param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="argument"/> is <see langword="null"/>.</exception>
    public static void ThrowIfNull<T>(
        [NotNull] this T? argument,
        [CallerArgumentExpression(nameof(argument))] string parameterName = null!)
        where T : class
        => ArgumentNullException.ThrowIfNull(argument, parameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> when <paramref name="argument"/> is
    /// <see langword="null"/>. Applies to nullable value types.
    /// </summary>
    /// <typeparam name="T">The value type of the argument to validate.</typeparam>
    /// <param name="argument">The argument to validate.</param>
    /// <param name="parameterName">
    /// The name of the parameter. This is supplied automatically by the compiler when the method
    /// is used as an extension method because of the <see cref="CallerArgumentExpressionAttribute"/>
    /// on this parameter.
    /// </param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="argument"/> is <see langword="null"/>.</exception>
    public static void ThrowIfNull<T>(
        [NotNull] this T? argument,
        [CallerArgumentExpression(nameof(argument))] string parameterName = null!)
        where T : struct
    {
        if (!argument.HasValue)
        {
            throw new ArgumentNullException(parameterName);
        }
    }
}
