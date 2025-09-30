namespace DevElf.Extensions;

/// <summary>
/// Provides extension methods for enum types to check if values are defined.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Determines whether the specified enum value is defined in its enum type.
    /// </summary>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    /// <param name="value">The enum value to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enum value is defined; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsDefined<TEnum>(this TEnum value)
        where TEnum : struct, Enum
        => Enum.IsDefined(value);

    /// <summary>
    /// Determines whether the specified enum value is not defined in its enum type.
    /// </summary>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    /// <param name="value">The enum value to check.</param>
    /// <returns>
    /// <see langword="true"/> if the enum value is not defined; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsNotDefined<TEnum>(this TEnum value)
        where TEnum : struct, Enum
        => !Enum.IsDefined(value);
}
