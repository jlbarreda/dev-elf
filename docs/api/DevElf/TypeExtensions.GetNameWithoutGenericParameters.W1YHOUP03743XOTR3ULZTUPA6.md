#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.GetNameWithoutGenericParameters\(this Type\) Method

Gets the name of the type without generic parameter indicators\.

```csharp
public static string GetNameWithoutGenericParameters(this System.Type type);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.GetNameWithoutGenericParameters(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to get the name from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The type name without the generic parameter count indicator \(e\.g\., "List" instead
of "List\`1"\)\.