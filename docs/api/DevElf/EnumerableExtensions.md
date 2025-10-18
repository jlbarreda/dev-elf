#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation')

## EnumerableExtensions Class

Provides argument validation extension methods for [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') 
collections\.

```csharp
public static class EnumerableExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; EnumerableExtensions

| Methods | |
| :--- | :--- |
| [ThrowIfNullOrEmpty&lt;T&gt;\(this IEnumerable&lt;T&gt;, string\)](EnumerableExtensions.ThrowIfNullOrEmpty.HOGY2PMFWW387IVPL7H586RR.md 'DevElf\.ArgumentValidation\.EnumerableExtensions\.ThrowIfNullOrEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') if the enumerable is  [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or an [System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException') if the  enumerable is empty\. |
