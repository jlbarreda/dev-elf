using System.Runtime.CompilerServices;

namespace DevElf.Extensions;

public static class EnumExtensions
{
    public static void IsDefined<TEnum>(this TEnum value)
        where TEnum : struct, Enum
        => Enum.IsDefined(value);
}
