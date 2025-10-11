#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[EnumerableExtensions](EnumerableExtensions.md 'DevElf\.Extensions\.EnumerableExtensions')

## EnumerableExtensions\.IsNullOrEmpty\<T\>\(this IEnumerable\<T\>\) Method

Determines whether the specified enumerable is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or 
empty\.

```csharp
public static bool IsNullOrEmpty<T>(this System.Collections.Generic.IEnumerable<T>? source);
```
#### Type parameters

<a name='DevElf.Extensions.EnumerableExtensions.IsNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the enumerable\.
#### Parameters

<a name='DevElf.Extensions.EnumerableExtensions.IsNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).source'></a>

`source` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](EnumerableExtensions.IsNullOrEmpty.L8EM3HR11BCX0GSI8EE8Q05H6.md#DevElf.Extensions.EnumerableExtensions.IsNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DevElf\.Extensions\.EnumerableExtensions\.IsNullOrEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the enumerable is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or 
            empty; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.