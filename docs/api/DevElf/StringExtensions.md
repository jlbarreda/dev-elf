#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation')

## StringExtensions Class

Provides extension helpers for validating [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') arguments\.

```csharp
public static class StringExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; StringExtensions

| Methods | |
| :--- | :--- |
| [ThrowIfNullOrEmpty\(this string, string\)](StringExtensions.ThrowIfNullOrEmpty.D8P8RJ38QN1GJYOQY7V7DCNDC.md 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrEmpty\(this string, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](StringExtensions.ThrowIfNullOrEmpty.D8P8RJ38QN1GJYOQY7V7DCNDC.md#DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrEmpty(thisstring,string).argument 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrEmpty\(this string, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or an empty string\. |
| [ThrowIfNullOrWhiteSpace\(this string, string\)](StringExtensions.ThrowIfNullOrWhiteSpace.WMBRDAXWAI57LA4GBGL662203.md 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrWhiteSpace\(this string, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](StringExtensions.ThrowIfNullOrWhiteSpace.WMBRDAXWAI57LA4GBGL662203.md#DevElf.ArgumentValidation.StringExtensions.ThrowIfNullOrWhiteSpace(thisstring,string).argument 'DevElf\.ArgumentValidation\.StringExtensions\.ThrowIfNullOrWhiteSpace\(this string, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), or an [System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException') when it consists only of white\-space characters\. |
