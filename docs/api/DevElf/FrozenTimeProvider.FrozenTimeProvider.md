#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[FrozenTimeProvider](FrozenTimeProvider.md 'DevElf\.FrozenTimeProvider')

## FrozenTimeProvider Constructors

| Overloads | |
| :--- | :--- |
| [FrozenTimeProvider\(DateTimeOffset\)](FrozenTimeProvider.FrozenTimeProvider.md#DevElf.FrozenTimeProvider.FrozenTimeProvider(System.DateTimeOffset) 'DevElf\.FrozenTimeProvider\.FrozenTimeProvider\(System\.DateTimeOffset\)') | Creates a new instance that will always return the provided instant in UTC\. The provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') is converted to UTC internally\. |
| [FrozenTimeProvider\(TimeProvider\)](FrozenTimeProvider.FrozenTimeProvider.md#DevElf.FrozenTimeProvider.FrozenTimeProvider(System.TimeProvider) 'DevElf\.FrozenTimeProvider\.FrozenTimeProvider\(System\.TimeProvider\)') | Creates a new instance that is frozen to the current value of the specified [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')\. |

<a name='DevElf.FrozenTimeProvider.FrozenTimeProvider(System.DateTimeOffset)'></a>

## FrozenTimeProvider\(DateTimeOffset\) Constructor

Creates a new instance that will always return the provided instant in UTC\.
The provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') is converted to UTC internally\.

```csharp
public FrozenTimeProvider(System.DateTimeOffset now);
```
#### Parameters

<a name='DevElf.FrozenTimeProvider.FrozenTimeProvider(System.DateTimeOffset).now'></a>

`now` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The instant to freeze\.

<a name='DevElf.FrozenTimeProvider.FrozenTimeProvider(System.TimeProvider)'></a>

## FrozenTimeProvider\(TimeProvider\) Constructor

Creates a new instance that is frozen to the current value of the
specified [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')\.

```csharp
public FrozenTimeProvider(System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.FrozenTimeProvider.FrozenTimeProvider(System.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider used to obtain the instant to freeze\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](FrozenTimeProvider.md#DevElf.FrozenTimeProvider.FrozenTimeProvider(System.TimeProvider).timeProvider 'DevElf\.FrozenTimeProvider\.FrozenTimeProvider\(System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.