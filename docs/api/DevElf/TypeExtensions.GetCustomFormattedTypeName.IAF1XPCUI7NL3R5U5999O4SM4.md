#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetCustomFormattedTypeName\(this Type, string, string, bool\) Method

Gets a formatted name for the type using a custom format string\.

```csharp
public static string GetCustomFormattedTypeName(this System.Type type, string format, string argumentSeparator=", ", bool useBuiltInTypeNameAliases=false);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeName(thisSystem.Type,string,string,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to format\.

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeName(thisSystem.Type,string,string,bool).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format string where \{0\} is the base type name and \{1\} is the generic arguments\.
For non\-generic types, only \{0\} is used\.

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeName(thisSystem.Type,string,string,bool).argumentSeparator'></a>

`argumentSeparator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string used to separate generic type arguments\. Default is ", "\.

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeName(thisSystem.Type,string,string,bool).useBuiltInTypeNameAliases'></a>

`useBuiltInTypeNameAliases` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to use C\# keyword aliases for built\-in types;
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string representation of the type name\. For non\-generic types, returns
the simple type name\.