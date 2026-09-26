#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[EnumExtensions](EnumExtensions.md 'DevElf\.Extensions\.EnumExtensions')

## EnumExtensions\.IsNotDefined\<TEnum\>\(this TEnum\) Method

Determines whether the specified enum value is not defined in its enum type\.

```csharp
public static bool IsNotDefined<TEnum>(this TEnum value)
    where TEnum : struct, System.Enum, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.Extensions.EnumExtensions.IsNotDefined_TEnum_(thisTEnum).TEnum'></a>

`TEnum`

The enum type\.
#### Parameters

<a name='DevElf.Extensions.EnumExtensions.IsNotDefined_TEnum_(thisTEnum).value'></a>

`value` [TEnum](EnumExtensions.IsNotDefined.RY2DLHY3SWCK2LPWGAEY4HEMA.md#DevElf.Extensions.EnumExtensions.IsNotDefined_TEnum_(thisTEnum).TEnum 'DevElf\.Extensions\.EnumExtensions\.IsNotDefined\<TEnum\>\(this TEnum\)\.TEnum')

The enum value to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the enum value is not defined; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.