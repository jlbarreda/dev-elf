#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[RoundRobinGeneratorBase&lt;T&gt;](RoundRobinGeneratorBase_T_.md 'DevElf\.RoundRobinGeneratorBase\<T\>')

## RoundRobinGeneratorBase\(T, T, IComparer\<T\>\) Constructor

Initializes a new instance of the [RoundRobinGeneratorBase&lt;T&gt;](RoundRobinGeneratorBase_T_.md 'DevElf\.RoundRobinGeneratorBase\<T\>') class\.

```csharp
protected RoundRobinGeneratorBase(T start, T end, System.Collections.Generic.IComparer<T>? comparer=null);
```
#### Parameters

<a name='DevElf.RoundRobinGeneratorBase_T_.RoundRobinGeneratorBase(T,T,System.Collections.Generic.IComparer_T_).start'></a>

`start` [T](RoundRobinGeneratorBase_T_.md#DevElf.RoundRobinGeneratorBase_T_.T 'DevElf\.RoundRobinGeneratorBase\<T\>\.T')

The starting value of the sequence\.

<a name='DevElf.RoundRobinGeneratorBase_T_.RoundRobinGeneratorBase(T,T,System.Collections.Generic.IComparer_T_).end'></a>

`end` [T](RoundRobinGeneratorBase_T_.md#DevElf.RoundRobinGeneratorBase_T_.T 'DevElf\.RoundRobinGeneratorBase\<T\>\.T')

The ending value of the sequence\.

<a name='DevElf.RoundRobinGeneratorBase_T_.RoundRobinGeneratorBase(T,T,System.Collections.Generic.IComparer_T_).comparer'></a>

`comparer` [System\.Collections\.Generic\.IComparer&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')[T](RoundRobinGeneratorBase_T_.md#DevElf.RoundRobinGeneratorBase_T_.T 'DevElf\.RoundRobinGeneratorBase\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')

The comparer to use for value comparison\. If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), the default comparer is used\.

#### Exceptions

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown if [start](RoundRobinGeneratorBase_T_..ctor.E1NI20SLHJC7G3YEVMRF0XE53.md#DevElf.RoundRobinGeneratorBase_T_.RoundRobinGeneratorBase(T,T,System.Collections.Generic.IComparer_T_).start 'DevElf\.RoundRobinGeneratorBase\<T\>\.RoundRobinGeneratorBase\(T, T, System\.Collections\.Generic\.IComparer\<T\>\)\.start') is greater than [end](RoundRobinGeneratorBase_T_..ctor.E1NI20SLHJC7G3YEVMRF0XE53.md#DevElf.RoundRobinGeneratorBase_T_.RoundRobinGeneratorBase(T,T,System.Collections.Generic.IComparer_T_).end 'DevElf\.RoundRobinGeneratorBase\<T\>\.RoundRobinGeneratorBase\(T, T, System\.Collections\.Generic\.IComparer\<T\>\)\.end')\.