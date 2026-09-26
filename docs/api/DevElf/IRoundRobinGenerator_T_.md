#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## IRoundRobinGenerator\<T\> Interface

Defines a generator that produces values in a round\-robin sequence\.

```csharp
public interface IRoundRobinGenerator<T>
    where T : System.IComparable<T>
```
#### Type parameters

<a name='DevElf.IRoundRobinGenerator_T_.T'></a>

`T`

A type that implements [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.

Derived  
&#8627; [RoundRobinGeneratorBase&lt;T&gt;](RoundRobinGeneratorBase_T_.md 'DevElf\.RoundRobinGeneratorBase\<T\>')  
&#8627; [RoundRobinNumberGenerator&lt;T&gt;](RoundRobinNumberGenerator_T_.md 'DevElf\.RoundRobinNumberGenerator\<T\>')

| Methods | |
| :--- | :--- |
| [NextValue\(\)](IRoundRobinGenerator_T_.NextValue().md 'DevElf\.IRoundRobinGenerator\<T\>\.NextValue\(\)') | Gets the next value in the round\-robin sequence\. |
