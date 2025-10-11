#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TimeProviderExtensions](TimeProviderExtensions.md 'DevElf\.Extensions\.TimeProviderExtensions')

## TimeProviderExtensions\.GetLocalNowAsDateTime\(this TimeProvider\) Method

Returns the current local time from the provider as a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

```csharp
public static System.DateTime GetLocalNowAsDateTime(this System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.Extensions.TimeProviderExtensions.GetLocalNowAsDateTime(thisSystem.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider\.

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')  
The current local [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](TimeProviderExtensions.GetLocalNowAsDateTime.M84J6LMDXEKC4KGHO8DWP8HO4.md#DevElf.Extensions.TimeProviderExtensions.GetLocalNowAsDateTime(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.GetLocalNowAsDateTime\(this System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.