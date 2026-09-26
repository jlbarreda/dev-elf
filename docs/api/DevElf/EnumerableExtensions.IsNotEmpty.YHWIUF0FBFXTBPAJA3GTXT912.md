#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[EnumerableExtensions](EnumerableExtensions.md 'DevElf\.Extensions\.EnumerableExtensions')

## EnumerableExtensions\.IsNotEmpty\<T\>\(this IEnumerable\<T\>\) Method

Determines whether the specified enumerable is not empty\.

```csharp
public static bool IsNotEmpty<T>(this System.Collections.Generic.IEnumerable<T> source);
```
#### Type parameters

<a name='DevElf.Extensions.EnumerableExtensions.IsNotEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the enumerable\.
#### Parameters

<a name='DevElf.Extensions.EnumerableExtensions.IsNotEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).source'></a>

`source` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](EnumerableExtensions.IsNotEmpty.YHWIUF0FBFXTBPAJA3GTXT912.md#DevElf.Extensions.EnumerableExtensions.IsNotEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DevElf\.Extensions\.EnumerableExtensions\.IsNotEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the enumerable is not empty; otherwise, 
            [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](EnumerableExtensions.IsNotEmpty.YHWIUF0FBFXTBPAJA3GTXT912.md#DevElf.Extensions.EnumerableExtensions.IsNotEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).source 'DevElf\.Extensions\.EnumerableExtensions\.IsNotEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.source') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.