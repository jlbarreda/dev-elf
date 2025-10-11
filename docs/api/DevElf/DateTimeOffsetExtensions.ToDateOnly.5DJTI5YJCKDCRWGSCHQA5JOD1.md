#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[DateTimeOffsetExtensions](DateTimeOffsetExtensions.md 'DevElf\.Extensions\.DateTimeOffsetExtensions')

## DateTimeOffsetExtensions\.ToDateOnly\(this DateTimeOffset\) Method

Returns the date component of the provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\.
The date portion is taken from the [System\.DateTimeOffset\.Date](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset.date 'System\.DateTimeOffset\.Date') property\.

```csharp
public static System.DateOnly ToDateOnly(this System.DateTimeOffset dateTimeOffset);
```
#### Parameters

<a name='DevElf.Extensions.DateTimeOffsetExtensions.ToDateOnly(thisSystem.DateTimeOffset).dateTimeOffset'></a>

`dateTimeOffset` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

#### Returns
[System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')