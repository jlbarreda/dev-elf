#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetTypeName\(this Type, bool\) Method

Gets the name of the type, optionally using C\# keyword aliases for built\-in types\.

```csharp
public static string GetTypeName(this System.Type type, bool useBuiltInTypeNameAliases=false);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetTypeName(thisSystem.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to get the name from\.

<a name='DevElf.Extensions.TypeExtensions.GetTypeName(thisSystem.Type,bool).useBuiltInTypeNameAliases'></a>

`useBuiltInTypeNameAliases` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to use C\# keyword aliases for built\-in types;
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The name of the type\.