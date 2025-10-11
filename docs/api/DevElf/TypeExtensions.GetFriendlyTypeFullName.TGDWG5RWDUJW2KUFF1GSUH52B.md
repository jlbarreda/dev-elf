#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetFriendlyTypeFullName\(this Type\) Method

Gets a friendly, readable full name for the type using angle bracket notation for
generic types\.

```csharp
public static string GetFriendlyTypeFullName(this System.Type type);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetFriendlyTypeFullName(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to format\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the type full name\. For generic types, returns the format
"Namespace\.TypeName\<T1, T2\>"\. For non\-generic types, returns the full type
name\.