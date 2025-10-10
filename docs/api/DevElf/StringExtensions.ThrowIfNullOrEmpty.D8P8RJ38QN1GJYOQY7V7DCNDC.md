#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[StringExtensions](StringExtensions.md 'DevElf\.ArgumentValidation\.StringExtensions')

## StringExtensions\.ThrowIfNullOrEmpty\(this string, string\) Method

Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](StringExtensions.ThrowIfNullOrEmpty.D8P8RJ38QN1GJYOQY7V7DCNDC.md#DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrEmpty(thisstring,string).argument 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrEmpty\(this string, string\)\.argument')
is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or an empty string\.

```csharp
public static void ThrowIfNullOrEmpty(this string? argument, string parameterName=null);
```
#### Parameters

<a name='DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrEmpty(thisstring,string).argument'></a>

`argument` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to validate\.

<a name='DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrEmpty(thisstring,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\. This is supplied automatically by the compiler
when the method is used as an extension method because of the
[System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute 'System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute') on this parameter\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [argument](StringExtensions.ThrowIfNullOrEmpty.D8P8RJ38QN1GJYOQY7V7DCNDC.md#DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrEmpty(thisstring,string).argument 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrEmpty\(this string, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or empty\.