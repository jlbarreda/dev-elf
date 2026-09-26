#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TimeProviderExtensions](TimeProviderExtensions.md 'DevElf\.Extensions\.TimeProviderExtensions')

## TimeProviderExtensions\.GetUtcToday\(this TimeProvider\) Method

Returns the current UTC date from the provider as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\.

```csharp
public static System.DateOnly GetUtcToday(this System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.Extensions.TimeProviderExtensions.GetUtcToday(thisSystem.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider\.

#### Returns
[System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')  
The current UTC [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](TimeProviderExtensions.GetUtcToday.8SIFE92OI2ICNT916X4QAWNY7.md#DevElf.Extensions.TimeProviderExtensions.GetUtcToday(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.GetUtcToday\(this System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.