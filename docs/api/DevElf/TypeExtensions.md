#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions')

## TypeExtensions Class

Provides extension methods for [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') to simplify type name formatting
and type analysis operations\.

```csharp
public static class TypeExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; TypeExtensions

| Methods | |
| :--- | :--- |
| [get\_BuiltInTypeAliasMap\(\)](TypeExtensions.get_BuiltInTypeAliasMap().md 'DevElf\.Extensions\.TypeExtensions\.get\_BuiltInTypeAliasMap\(\)') | Gets the dictionary mapping built\-in types to their C\# keyword aliases\. |
| [GetCustomFormattedTypeFullName\(this Type, string, string\)](TypeExtensions.GetCustomFormattedTypeFullName.P76O9STWHPAGRI25QVIUQ5MVD.md 'DevElf\.Extensions\.TypeExtensions\.GetCustomFormattedTypeFullName\(this System\.Type, string, string\)') | Gets a formatted full name for the type using a custom format string\. |
| [GetCustomFormattedTypeName\(this Type, string, string, bool\)](TypeExtensions.GetCustomFormattedTypeName.IAF1XPCUI7NL3R5U5999O4SM4.md 'DevElf\.Extensions\.TypeExtensions\.GetCustomFormattedTypeName\(this System\.Type, string, string, bool\)') | Gets a formatted name for the type using a custom format string\. |
| [GetFriendlyTypeFullName\(this Type\)](TypeExtensions.GetFriendlyTypeFullName.TGDWG5RWDUJW2KUFF1GSUH52B.md 'DevElf\.Extensions\.TypeExtensions\.GetFriendlyTypeFullName\(this System\.Type\)') | Gets a friendly, readable full name for the type using angle bracket notation for generic types\. |
| [GetFriendlyTypeName\(this Type, bool\)](TypeExtensions.GetFriendlyTypeName.J35G2Y7DEMNMKUW3HYFEJQRE4.md 'DevElf\.Extensions\.TypeExtensions\.GetFriendlyTypeName\(this System\.Type, bool\)') | Gets a friendly, readable name for the type using angle bracket notation for generic types\. |
| [GetNameWithoutGenericParameters\(this Type\)](TypeExtensions.GetNameWithoutGenericParameters.W1YHOUP03743XOTR3ULZTUPA6.md 'DevElf\.Extensions\.TypeExtensions\.GetNameWithoutGenericParameters\(this System\.Type\)') | Gets the name of the type without generic parameter indicators\. |
| [GetTypeName\(this Type, bool\)](TypeExtensions.GetTypeName.UH859SB3JKYGI29AZPHHWSOT5.md 'DevElf\.Extensions\.TypeExtensions\.GetTypeName\(this System\.Type, bool\)') | Gets the name of the type, optionally using C\# keyword aliases for built\-in types\. |
| [IsIEnumerableOfT\(this Type, bool\)](TypeExtensions.IsIEnumerableOfT.94FI3DNSKIQR77KQEYY3O9VJ6.md 'DevElf\.Extensions\.TypeExtensions\.IsIEnumerableOfT\(this System\.Type, bool\)') | Determines whether the specified type implements [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')\. |
| [IsStatic\(this Type\)](TypeExtensions.IsStatic.3K24BJS6E9QC8MFS6MLNUI3FA.md 'DevElf\.Extensions\.TypeExtensions\.IsStatic\(this System\.Type\)') | Determines whether the specified type is a static class\. |
| [TryGetIEnumerableOfTType\(this Type, Type, bool\)](TypeExtensions.TryGetIEnumerableOfTType.0M5ESH17YJABIKN8X3RLK96BC.md 'DevElf\.Extensions\.TypeExtensions\.TryGetIEnumerableOfTType\(this System\.Type, System\.Type, bool\)') | Attempts to get the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') interface type from a type that implements it\. |
| [TryGetTypeOfTFromIEnumerableOfT\(this Type, Type, bool\)](TypeExtensions.TryGetTypeOfTFromIEnumerableOfT.W0NGC76YSUAP62VXD2CX03CT1.md 'DevElf\.Extensions\.TypeExtensions\.TryGetTypeOfTFromIEnumerableOfT\(this System\.Type, System\.Type, bool\)') | Attempts to get the element type T from a type that implements [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')\. |
