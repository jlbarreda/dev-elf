#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TimeProviderExtensions](TimeProviderExtensions.md 'DevElf\.Extensions\.TimeProviderExtensions')

## TimeProviderExtensions\.GetToday\(this TimeProvider\) Method

Returns the current local date from the provider as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\.

```csharp
public static System.DateOnly GetToday(this System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.Extensions.TimeProviderExtensions.GetToday(thisSystem.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider\.

#### Returns
[System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')  
The current local [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](TimeProviderExtensions.GetToday.ZV4BS2Q217E0OPUMVKLSXRLHE.md#DevElf.Extensions.TimeProviderExtensions.GetToday(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.GetToday\(this System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.