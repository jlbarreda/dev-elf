#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetFriendlyTypeName\(this Type, bool\) Method

Gets a friendly, readable name for the type using angle bracket notation for generic
types\.

```csharp
public static string GetFriendlyTypeName(this System.Type type, bool useBuiltInTypeNameAliases=false);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetFriendlyTypeName(thisSystem.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to format\.

<a name='DevElf.Extensions.TypeExtensions.GetFriendlyTypeName(thisSystem.Type,bool).useBuiltInTypeNameAliases'></a>

`useBuiltInTypeNameAliases` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to use C\# keyword aliases for built\-in types;
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the type name\. For generic types, returns the format
"TypeName\<T1, T2\>"\. For non\-generic types, returns the simple type name\.