#### [DevElf](README.md 'README')

## DevElf Namespace

| Classes | |
| :--- | :--- |
| [FrozenTimeProvider](FrozenTimeProvider.md 'DevElf\.FrozenTimeProvider') | A [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider') that always returns a fixed point in time\. Useful for tests and deterministic time\-dependent logic\. |
| [RoundRobinGeneratorBase&lt;T&gt;](RoundRobinGeneratorBase_T_.md 'DevElf\.RoundRobinGeneratorBase\<T\>') | Provides a base implementation for round\-robin generators using a comparer\. |
| [RoundRobinNumberGenerator&lt;T&gt;](RoundRobinNumberGenerator_T_.md 'DevElf\.RoundRobinNumberGenerator\<T\>') | Generates numbers in a round\-robin fashion between a start and end value\. |
| [SerializableExceptionWrapper](SerializableExceptionWrapper.md 'DevElf\.SerializableExceptionWrapper') | Wraps an [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') for serialization, including its properties and inner exception\. |

| Interfaces | |
| :--- | :--- |
| [IRoundRobinGenerator&lt;T&gt;](IRoundRobinGenerator_T_.md 'DevElf\.IRoundRobinGenerator\<T\>') | Defines a generator that produces values in a round\-robin sequence\. |
