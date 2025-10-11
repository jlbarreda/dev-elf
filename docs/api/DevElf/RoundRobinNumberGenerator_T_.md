#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## RoundRobinNumberGenerator\<T\> Class

Generates numbers in a round\-robin fashion between a start and end value\.

```csharp
public class RoundRobinNumberGenerator<T> : DevElf.IRoundRobinGenerator<T>
    where T : System.Numerics.INumber<T>, System.IComparable<T>
```
#### Type parameters

<a name='DevElf.RoundRobinNumberGenerator_T_.T'></a>

`T`

A numeric type implementing [System\.Numerics\.INumber&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumber-1 'System\.Numerics\.INumber\`1') and [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; RoundRobinNumberGenerator\<T\>

Implements [DevElf\.IRoundRobinGenerator&lt;](IRoundRobinGenerator_T_.md 'DevElf\.IRoundRobinGenerator\<T\>')[T](RoundRobinNumberGenerator_T_.md#DevElf.RoundRobinNumberGenerator_T_.T 'DevElf\.RoundRobinNumberGenerator\<T\>\.T')[&gt;](IRoundRobinGenerator_T_.md 'DevElf\.IRoundRobinGenerator\<T\>')

| Constructors | |
| :--- | :--- |
| [RoundRobinNumberGenerator\(T, T\)](RoundRobinNumberGenerator_T_..ctor.BQ7SXSX0RJJGA8DO29J5OPPQ6.md 'DevElf\.RoundRobinNumberGenerator\<T\>\.RoundRobinNumberGenerator\(T, T\)') | Initializes a new instance of the [RoundRobinNumberGenerator&lt;T&gt;](RoundRobinNumberGenerator_T_.md 'DevElf\.RoundRobinNumberGenerator\<T\>') class\. |

| Methods | |
| :--- | :--- |
| [NextValue\(\)](RoundRobinNumberGenerator_T_.NextValue().md 'DevElf\.RoundRobinNumberGenerator\<T\>\.NextValue\(\)') | Gets the next value in the round\-robin sequence\. |
