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
    public static bool IsNull([NotNullWhen(false)] this string? text) => text is null;

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is <see langword="null"/>
    /// or an empty string (<c>string.Empty</c>).
    /// </summary>
    /// <param name="text">The string to check.</param>
    public static bool IsNullOrEmpty([NotNullWhen(false)] this string? text) => string.IsNullOrEmpty(text);

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="text"/> is <see langword="null"/>
    /// or consists only of white-space characters.
    /// </summary>
    /// <param name="text">The string to check.</param>
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? text) => string.IsNullOrWhiteSpace(text);
}
