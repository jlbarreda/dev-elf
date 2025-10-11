#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[RoundRobinNumberGenerator&lt;T&gt;](RoundRobinNumberGenerator_T_.md 'DevElf\.RoundRobinNumberGenerator\<T\>')

## RoundRobinNumberGenerator\(T, T\) Constructor

Initializes a new instance of the [RoundRobinNumberGenerator&lt;T&gt;](RoundRobinNumberGenerator_T_.md 'DevElf\.RoundRobinNumberGenerator\<T\>') class\.

```csharp
public RoundRobinNumberGenerator(T start, T end);
```
#### Parameters

<a name='DevElf.RoundRobinNumberGenerator_T_.RoundRobinNumberGenerator(T,T).start'></a>

`start` [T](RoundRobinNumberGenerator_T_.md#DevElf.RoundRobinNumberGenerator_T_.T 'DevElf\.RoundRobinNumberGenerator\<T\>\.T')

The starting value of the sequence\.

<a name='DevElf.RoundRobinNumberGenerator_T_.RoundRobinNumberGenerator(T,T).end'></a>

`end` [T](RoundRobinNumberGenerator_T_.md#DevElf.RoundRobinNumberGenerator_T_.T 'DevElf\.RoundRobinNumberGenerator\<T\>\.T')

The ending value of the sequence\.

#### Exceptions

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown if [start](RoundRobinNumberGenerator_T_..ctor.BQ7SXSX0RJJGA8DO29J5OPPQ6.md#DevElf.RoundRobinNumberGenerator_T_.RoundRobinNumberGenerator(T,T).start 'DevElf\.RoundRobinNumberGenerator\<T\>\.RoundRobinNumberGenerator\(T, T\)\.start') is greater than [end](RoundRobinNumberGenerator_T_..ctor.BQ7SXSX0RJJGA8DO29J5OPPQ6.md#DevElf.RoundRobinNumberGenerator_T_.RoundRobinNumberGenerator(T,T).end 'DevElf\.RoundRobinNumberGenerator\<T\>\.RoundRobinNumberGenerator\(T, T\)\.end')\.