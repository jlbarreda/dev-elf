#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## FrozenTimeProvider Class

A [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider') that always returns a fixed point in time\.
Useful for tests and deterministic time\-dependent logic\.

```csharp
public sealed class FrozenTimeProvider : System.TimeProvider
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider') &#129106; FrozenTimeProvider

| Constructors | |
| :--- | :--- |
| [FrozenTimeProvider\(DateTimeOffset\)](FrozenTimeProvider.FrozenTimeProvider.md#DevElf.FrozenTimeProvider.FrozenTimeProvider(System.DateTimeOffset) 'DevElf\.FrozenTimeProvider\.FrozenTimeProvider\(System\.DateTimeOffset\)') | Creates a new instance that will always return the provided instant in UTC\. The provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') is converted to UTC internally\. |
| [FrozenTimeProvider\(TimeProvider\)](FrozenTimeProvider.FrozenTimeProvider.md#DevElf.FrozenTimeProvider.FrozenTimeProvider(System.TimeProvider) 'DevElf\.FrozenTimeProvider\.FrozenTimeProvider\(System\.TimeProvider\)') | Creates a new instance that is frozen to the current value of the specified [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')\. |

| Methods | |
| :--- | :--- |
| [GetUtcNow\(\)](FrozenTimeProvider.GetUtcNow().md 'DevElf\.FrozenTimeProvider\.GetUtcNow\(\)') | Returns the frozen instant as a UTC [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')\. |
