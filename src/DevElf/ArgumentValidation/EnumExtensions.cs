using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides helpers for validating enum arguments.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> when the provided enum value is not defined
    /// for the enum type <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum">The enum type to validate.</typeparam>
    /// <param name="argument">The enum value to validate.</param>
    /// <param name="parameterName">
    /// The name of the parameter. This is supplied automatically by the compiler when the method is
    /// used as an extension method because of the <see cref="CallerArgumentExpressionAttribute"/> on this parameter.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="argument"/> is not a defined value.</exception>
    public static void ThrowIfNotDefined<TEnum>(
        this TEnum argument,
        [CallerArgumentExpression(nameof(argument))] string parameterName = null!)
        where TEnum : struct, Enum
    {
        if (!Enum.IsDefined(argument))
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                argument,
                $"Undefined '{typeof(TEnum).FullName}' enum value.");
        }
    }
}
