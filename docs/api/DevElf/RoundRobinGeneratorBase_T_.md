#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## RoundRobinGeneratorBase\<T\> Class

Provides a base implementation for round\-robin generators using a comparer\.

```csharp
public abstract class RoundRobinGeneratorBase<T> : DevElf.IRoundRobinGenerator<T>
    where T : System.IComparable<T>
```
#### Type parameters

<a name='DevElf.RoundRobinGeneratorBase_T_.T'></a>

`T`

A type implementing [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; RoundRobinGeneratorBase\<T\>

Implements [DevElf\.IRoundRobinGenerator&lt;](IRoundRobinGenerator_T_.md 'DevElf\.IRoundRobinGenerator\<T\>')[T](RoundRobinGeneratorBase_T_.md#DevElf.RoundRobinGeneratorBase_T_.T 'DevElf\.RoundRobinGeneratorBase\<T\>\.T')[&gt;](IRoundRobinGenerator_T_.md 'DevElf\.IRoundRobinGenerator\<T\>')

| Constructors | |
| :--- | :--- |
| [RoundRobinGeneratorBase\(T, T, IComparer&lt;T&gt;\)](RoundRobinGeneratorBase_T_..ctor.E1NI20SLHJC7G3YEVMRF0XE53.md 'DevElf\.RoundRobinGeneratorBase\<T\>\.RoundRobinGeneratorBase\(T, T, System\.Collections\.Generic\.IComparer\<T\>\)') | Initializes a new instance of the [RoundRobinGeneratorBase&lt;T&gt;](RoundRobinGeneratorBase_T_.md 'DevElf\.RoundRobinGeneratorBase\<T\>') class\. |

| Methods | |
| :--- | :--- |
| [Increment\(T\)](RoundRobinGeneratorBase_T_.Increment.1YMOTJ0TC8DKL0BR7911JNZT1.md 'DevElf\.RoundRobinGeneratorBase\<T\>\.Increment\(T\)') | Increments the value for the next round\-robin step\. |
| [NextValue\(\)](RoundRobinGeneratorBase_T_.NextValue().md 'DevElf\.RoundRobinGeneratorBase\<T\>\.NextValue\(\)') | Gets the next value in the round\-robin sequence\. |
