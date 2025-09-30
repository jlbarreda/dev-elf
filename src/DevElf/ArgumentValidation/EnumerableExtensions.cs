using System.Runtime.CompilerServices;
using DevElf.Extensions;

namespace DevElf.ArgumentValidation;

/// <summary>
/// Provides argument validation extension methods for <see cref="IEnumerable{T}"/> 
/// collections.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if the enumerable is 
    /// <see langword="null"/> or an <see cref="ArgumentException"/> if the 
    /// enumerable is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to validate.</param>
    /// <param name="parameterName">
    /// The name of the parameter being validated. This is automatically 
    /// captured from the calling code.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// <paramref name="source"/> is empty.
    /// </exception>
    public static void ThrowIfNullOrEmpty<T>(
        this IEnumerable<T> source,
        [CallerArgumentExpression(nameof(source))] string parameterName = null!)
    {
        source.ThrowIfNull(parameterName);

        if (source.IsEmpty())
        {
            throw new ArgumentException("The collection cannot be empty.", parameterName);
        }
    }
}
