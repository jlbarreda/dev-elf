#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[EnumerableExtensions](EnumerableExtensions.md 'DevElf\.ArgumentValidation\.EnumerableExtensions')

## EnumerableExtensions\.ThrowIfNullOrEmpty\<T\>\(this IEnumerable\<T\>, string\) Method

Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') if the enumerable is 
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or an [System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException') if the 
enumerable is empty\.

```csharp
public static void ThrowIfNullOrEmpty<T>(this System.Collections.Generic.IEnumerable<T> source, string parameterName=null);
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).T'></a>

`T`

The type of elements in the enumerable\.
#### Parameters

<a name='DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).source'></a>

`source` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](EnumerableExtensions.ThrowIfNullOrEmpty.HOGY2PMFWW387IVPL7H586RR.md#DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).T 'DevElf\.ArgumentValidation\.EnumerableExtensions\.ThrowIfNullOrEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable to validate\.

<a name='DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being validated\. This is automatically 
captured from the calling code\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](EnumerableExtensions.ThrowIfNullOrEmpty.HOGY2PMFWW387IVPL7H586RR.md#DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).source 'DevElf\.ArgumentValidation\.EnumerableExtensions\.ThrowIfNullOrEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, string\)\.source') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
[source](EnumerableExtensions.ThrowIfNullOrEmpty.HOGY2PMFWW387IVPL7H586RR.md#DevElf.ArgumentValidation.EnumerableExtensions.ThrowIfNullOrEmpty_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).source 'DevElf\.ArgumentValidation\.EnumerableExtensions\.ThrowIfNullOrEmpty\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, string\)\.source') is empty\.