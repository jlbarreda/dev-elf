#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[StringExtensions](StringExtensions.md 'DevElf\.Extensions\.StringExtensions')

## StringExtensions\.IsNullOrEmpty\(this string\) Method

Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when [text](StringExtensions.IsNullOrEmpty.83A6J6VCAV38Q1YDNQBEEPYKB.md#DevElf.Extensions.StringExtensions.IsNullOrEmpty(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNullOrEmpty\(this string\)\.text') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')
or an empty string \(`string.Empty`\)\.

```csharp
public static bool IsNullOrEmpty(this string? text);
```
#### Parameters

<a name='DevElf.Extensions.StringExtensions.IsNullOrEmpty(thisstring).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if [text](StringExtensions.IsNullOrEmpty.83A6J6VCAV38Q1YDNQBEEPYKB.md#DevElf.Extensions.StringExtensions.IsNullOrEmpty(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNullOrEmpty\(this string\)\.text') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or 
            empty; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.