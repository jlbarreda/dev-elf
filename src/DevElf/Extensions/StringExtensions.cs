using System.Diagnostics.CodeAnalysis;

namespace DevElf.Extensions;

/// <summary>
/// Convenience extension methods for nullable <see cref="string"/> instances.
/// These helpers make common null/empty/whitespace checks read more clearly at call sites.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is <see langword="null"/>.
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is <see langword="null"/>; 
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNull([NotNullWhen(false)] this string? text) => text is null;

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is not 
    /// <see langword="null"/>.
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is not <see langword="null"/>; 
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNotNull([NotNullWhen(true)] this string? text) => text is not null;

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is <see langword="null"/>
    /// or an empty string (<c>string.Empty</c>).
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is <see langword="null"/> or 
    /// empty; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNullOrEmpty([NotNullWhen(false)] this string? text) => string.IsNullOrEmpty(text);

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is not 
    /// <see langword="null"/> and not an empty string.
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is not <see langword="null"/> 
    /// and not empty; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNotNullOrEmpty([NotNullWhen(true)] this string? text) => !string.IsNullOrEmpty(text);

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is <see langword="null"/>
    /// or consists only of white-space characters.
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is <see langword="null"/> or 
    /// consists only of white-space characters; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? text) => string.IsNullOrWhiteSpace(text);

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is not 
    /// <see langword="null"/> and does not consist only of white-space characters.
    /// </summary>
    /// <param name="text">The string to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="text"/> is not <see langword="null"/> 
    /// and does not consist only of white-space characters; otherwise, 
    /// <see langword="false"/>.
    /// </returns>
    public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)] this string? text) => !string.IsNullOrWhiteSpace(text);
}
