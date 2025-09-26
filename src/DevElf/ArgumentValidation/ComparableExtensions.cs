using System.Runtime.CompilerServices;

namespace DevElf.ArgumentValidation;

public static class ComparableExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than <paramref name="other"/>.
    /// Optionally throws an <see cref="ArgumentNullException"/> if either argument is null.
    /// </summary>
    /// <typeparam name="T">The type of the arguments, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="value">The value to validate.</param>
    /// <param name="other">The value to compare against.</param>
    /// <param name="throwIfNull">If true, throws if <paramref name="value"/> or <paramref name="other"/> is null.</param>
    /// <param name="parameterName">The name of the <paramref name="value"/> parameter (automatically provided).</param>
    /// <param name="otherParameterName">The name of the <paramref name="other"/> parameter (automatically provided).</param>
    public static void ThrowIfLessThan<T>(
        this T value,
        T other,
        bool throwIfNull = true,
        [CallerArgumentExpression(nameof(value))] string parameterName = null!,
        [CallerArgumentExpression(nameof(other))] string otherParameterName = null!)
        where T : IComparable<T>
    {
        if (throwIfNull)
        {
            ArgumentNullException.ThrowIfNull(value);
            ArgumentNullException.ThrowIfNull(other);
        }

        if (value is not null && other is not null && value.CompareTo(other) < 0)
        {
            throw new ArgumentOutOfRangeException(
                parameterName,
                $"'{parameterName}' must be greater than or equal to '{otherParameterName}'. {parameterName}: '{value}'. {otherParameterName}: '{other}'.");
        }
    }
}
