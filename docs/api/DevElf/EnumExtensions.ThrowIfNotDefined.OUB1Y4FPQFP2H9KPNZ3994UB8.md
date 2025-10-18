#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[EnumExtensions](EnumExtensions.md 'DevElf\.ArgumentValidation\.EnumExtensions')

## EnumExtensions\.ThrowIfNotDefined\<TEnum\>\(this TEnum, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') when the provided enum value is not defined
for the enum type [TEnum](EnumExtensions.ThrowIfNotDefined.OUB1Y4FPQFP2H9KPNZ3994UB8.md#DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).TEnum 'DevElf\.ArgumentValidation\.EnumExtensions\.ThrowIfNotDefined\<TEnum\>\(this TEnum, string\)\.TEnum')\.

```csharp
public static void ThrowIfNotDefined<TEnum>(this TEnum argument, string parameterName=null)
    where TEnum : struct, System.Enum, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).TEnum'></a>

`TEnum`

The enum type to validate\.
#### Parameters

<a name='DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).argument'></a>

`argument` [TEnum](EnumExtensions.ThrowIfNotDefined.OUB1Y4FPQFP2H9KPNZ3994UB8.md#DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).TEnum 'DevElf\.ArgumentValidation\.EnumExtensions\.ThrowIfNotDefined\<TEnum\>\(this TEnum, string\)\.TEnum')

The enum value to validate\.

<a name='DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\. This is supplied automatically by the compiler when the method is
used as an extension method because of the [System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute 'System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute') on this parameter\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [argument](EnumExtensions.ThrowIfNotDefined.OUB1Y4FPQFP2H9KPNZ3994UB8.md#DevElf.ArgumentValidation.EnumExtensions.ThrowIfNotDefined_TEnum_(thisTEnum,string).argument 'DevElf\.ArgumentValidation\.EnumExtensions\.ThrowIfNotDefined\<TEnum\>\(this TEnum, string\)\.argument') is not a defined value\.