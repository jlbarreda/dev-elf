#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[StringExtensions](StringExtensions.md 'DevElf\.Extensions\.StringExtensions')

## StringExtensions\.IsNotNullOrWhiteSpace\(this string\) Method

Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when [text](StringExtensions.IsNotNullOrWhiteSpace.9919O1K4JIH04407ZF15FU221.md#DevElf.Extensions.StringExtensions.IsNotNullOrWhiteSpace(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNotNullOrWhiteSpace\(this string\)\.text') is not 
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') and does not consist only of white\-space characters\.

```csharp
public static bool IsNotNullOrWhiteSpace(this string? text);
```
#### Parameters

<a name='DevElf.Extensions.StringExtensions.IsNotNullOrWhiteSpace(thisstring).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if [text](StringExtensions.IsNotNullOrWhiteSpace.9919O1K4JIH04407ZF15FU221.md#DevElf.Extensions.StringExtensions.IsNotNullOrWhiteSpace(thisstring).text 'DevElf\.Extensions\.StringExtensions\.IsNotNullOrWhiteSpace\(this string\)\.text') is not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') 
            and does not consist only of white\-space characters; otherwise, 
            [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.