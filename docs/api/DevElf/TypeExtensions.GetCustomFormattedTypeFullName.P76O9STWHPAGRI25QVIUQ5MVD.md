#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetCustomFormattedTypeFullName\(this Type, string, string\) Method

Gets a formatted full name for the type using a custom format string\.

```csharp
public static string GetCustomFormattedTypeFullName(this System.Type type, string format, string argumentSeparator=", ");
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeFullName(thisSystem.Type,string,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to format\.

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeFullName(thisSystem.Type,string,string).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format string where \{0\} is the base type full name and \{1\} is the generic
arguments\. For non\-generic types, only \{0\} is used\.

<a name='DevElf.Extensions.TypeExtensions.GetCustomFormattedTypeFullName(thisSystem.Type,string,string).argumentSeparator'></a>

`argumentSeparator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string used to separate generic type arguments\. Default is ", "\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string representation of the type full name\. For non\-generic types,
returns the full type name\.