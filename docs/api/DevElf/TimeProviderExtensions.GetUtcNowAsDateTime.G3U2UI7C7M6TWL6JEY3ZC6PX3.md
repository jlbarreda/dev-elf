#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TimeProviderExtensions](TimeProviderExtensions.md 'DevElf\.Extensions\.TimeProviderExtensions')

## TimeProviderExtensions\.GetUtcNowAsDateTime\(this TimeProvider\) Method

Returns the current UTC time from the provider as a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

```csharp
public static System.DateTime GetUtcNowAsDateTime(this System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.Extensions.TimeProviderExtensions.GetUtcNowAsDateTime(thisSystem.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider\.

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')  
The current UTC [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](TimeProviderExtensions.GetUtcNowAsDateTime.G3U2UI7C7M6TWL6JEY3ZC6PX3.md#DevElf.Extensions.TimeProviderExtensions.GetUtcNowAsDateTime(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.GetUtcNowAsDateTime\(this System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.