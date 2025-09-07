namespace DevElf.Extensions;

public static class StringExtensions {
    public static bool IsNull(this string? text) => text is null;

    public static bool IsNullOrEmpty(this string? text) => string.IsNullOrEmpty(text);

    public static bool IsNullOrWhiteSpace(this string? text) => string.IsNullOrWhiteSpace(text);
}
