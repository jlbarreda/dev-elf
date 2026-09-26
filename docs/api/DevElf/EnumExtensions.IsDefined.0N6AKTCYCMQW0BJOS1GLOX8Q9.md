#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[EnumExtensions](EnumExtensions.md 'DevElf\.Extensions\.EnumExtensions')

## EnumExtensions\.IsDefined\<TEnum\>\(this TEnum\) Method

Determines whether the specified enum value is defined in its enum type\.

```csharp
public static bool IsDefined<TEnum>(this TEnum value)
    where TEnum : struct, System.Enum, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.Extensions.EnumExtensions.IsDefined_TEnum_(thisTEnum).TEnum'></a>

`TEnum`

The enum type\.
#### Parameters

<a name='DevElf.Extensions.EnumExtensions.IsDefined_TEnum_(thisTEnum).value'></a>

`value` [TEnum](EnumExtensions.IsDefined.0N6AKTCYCMQW0BJOS1GLOX8Q9.md#DevElf.Extensions.EnumExtensions.IsDefined_TEnum_(thisTEnum).TEnum 'DevElf\.Extensions\.EnumExtensions\.IsDefined\<TEnum\>\(this TEnum\)\.TEnum')

The enum value to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the enum value is defined; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.