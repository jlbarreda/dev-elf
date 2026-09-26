#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[StringExtensions](StringExtensions.md 'DevElf\.Extensions\.StringExtensions')

## StringExtensions\.IsNullOrWhiteSpace\(this string\) Method

Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when [text](StringExtensions.IsNullOrWhiteSpace.TPNVX18CCNJW0BW0NI3QBH3X1.md#DevElf.Extensions.StringExtensions.IsNullOrWhiteSpace(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNullOrWhiteSpace\(this string\)\.text') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')
or consists only of white\-space characters\.

```csharp
public static bool IsNullOrWhiteSpace(this string? text);
```
#### Parameters

<a name='DevElf.Extensions.StringExtensions.IsNullOrWhiteSpace(thisstring).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if [text](StringExtensions.IsNullOrWhiteSpace.TPNVX18CCNJW0BW0NI3QBH3X1.md#DevElf.Extensions.StringExtensions.IsNullOrWhiteSpace(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNullOrWhiteSpace\(this string\)\.text') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or 
            consists only of white\-space characters; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.