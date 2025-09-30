using DevElf.ArgumentValidation;

namespace DevElf.Extensions;

/// <summary>
/// Provides extension methods for <see cref="IEnumerable{T}"/> collections.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// Determines whether the specified enumerable is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enumerable is empty; otherwise, 
    /// <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static bool IsEmpty<T>(this IEnumerable<T> source)
    {
        source.ThrowIfNull();

        return !source.Any();
    }

    /// <summary>
    /// Determines whether the specified enumerable is not empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enumerable is not empty; otherwise, 
    /// <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        => !source.IsEmpty();

    /// <summary>
    /// Determines whether the specified enumerable is <see langword="null"/> or 
    /// empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enumerable is <see langword="null"/> or 
    /// empty; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? source)
        => !source.IsNotNullOrEmpty();

    /// <summary>
    /// Determines whether the specified enumerable is not <see langword="null"/> 
    /// and not empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enumerable is not <see langword="null"/> 
    /// and not empty; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? source)
        => source?.Any() is true;
}
