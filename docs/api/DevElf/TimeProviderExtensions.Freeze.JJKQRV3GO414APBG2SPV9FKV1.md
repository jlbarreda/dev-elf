#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[TimeProviderExtensions](TimeProviderExtensions.md 'DevElf\.Extensions\.TimeProviderExtensions')

## TimeProviderExtensions\.Freeze\(this TimeProvider\) Method

Returns a [FrozenTimeProvider](FrozenTimeProvider.md 'DevElf\.FrozenTimeProvider') that is frozen to the current instant of [timeProvider](TimeProviderExtensions.Freeze.JJKQRV3GO414APBG2SPV9FKV1.md#DevElf.Extensions.TimeProviderExtensions.Freeze(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.Freeze\(this System\.TimeProvider\)\.timeProvider')\.

```csharp
public static System.TimeProvider Freeze(this System.TimeProvider timeProvider);
```
#### Parameters

<a name='DevElf.Extensions.TimeProviderExtensions.Freeze(thisSystem.TimeProvider).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The source time provider\.

#### Returns
[System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')  
A frozen time provider\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [timeProvider](TimeProviderExtensions.Freeze.JJKQRV3GO414APBG2SPV9FKV1.md#DevElf.Extensions.TimeProviderExtensions.Freeze(thisSystem.TimeProvider).timeProvider 'DevElf\.Extensions\.TimeProviderExtensions\.Freeze\(this System\.TimeProvider\)\.timeProvider') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.