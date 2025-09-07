using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

public static class StringExtensions
{
    public static void ThrowIfNullOrEmpty(
        [NotNull] this string? argument,
        [CallerArgumentExpression(nameof(argument))] string parameterName = null!)
            => ArgumentNullException.ThrowIfNullOrEmpty(argument, parameterName);
}
