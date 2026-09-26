#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TypeExtensions](TypeExtensions.md 'DevElf\.Extensions\.TypeExtensions')

## TypeExtensions\.TryGetTypeOfTFromIEnumerableOfT\(this Type, Type, bool\) Method

Attempts to get the element type T from a type that implements
[System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')\.

```csharp
public static bool TryGetTypeOfTFromIEnumerableOfT(this System.Type type, out System.Type? typeOfT, bool excludeString=false);
```
#### Parameters

<a name='DevElf.Extensions.TypeExtensions.TryGetTypeOfTFromIEnumerableOfT(thisSystem.Type,System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to check\.

<a name='DevElf.Extensions.TypeExtensions.TryGetTypeOfTFromIEnumerableOfT(thisSystem.Type,System.Type,bool).typeOfT'></a>

`typeOfT` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

When this method returns, contains the element type T if the type implements
[System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'); otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DevElf.Extensions.TypeExtensions.TryGetTypeOfTFromIEnumerableOfT(thisSystem.Type,System.Type,bool).excludeString'></a>

`excludeString` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to exclude [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String') from being considered as
            [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the type implements [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') and
            the element type was retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.