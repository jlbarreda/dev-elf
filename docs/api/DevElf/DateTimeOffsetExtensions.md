#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions')

## DateTimeOffsetExtensions Class

Extension helpers for [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') conversions to [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly') and [System\.TimeOnly](https://learn.microsoft.com/en-us/dotnet/api/system.timeonly 'System\.TimeOnly')\.

```csharp
public static class DateTimeOffsetExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; DateTimeOffsetExtensions

| Methods | |
| :--- | :--- |
| [LocalTimeOfDayAsTimeOnly\(this DateTimeOffset\)](DateTimeOffsetExtensions.LocalTimeOfDayAsTimeOnly.3V6AA5YCYRJVWJ22EJ3V4M9HB.md 'DevElf\.Extensions\.DateTimeOffsetExtensions\.LocalTimeOfDayAsTimeOnly\(this System\.DateTimeOffset\)') | Returns the local time\-of\-day component as a [System\.TimeOnly](https://learn.microsoft.com/en-us/dotnet/api/system.timeonly 'System\.TimeOnly')\. |
| [TimeOfDayAsTimeOnly\(this DateTimeOffset\)](DateTimeOffsetExtensions.TimeOfDayAsTimeOnly.LV829LH80XT0GJ710EA0YJF1A.md 'DevElf\.Extensions\.DateTimeOffsetExtensions\.TimeOfDayAsTimeOnly\(this System\.DateTimeOffset\)') | Returns the time\-of\-day component as a [System\.TimeOnly](https://learn.microsoft.com/en-us/dotnet/api/system.timeonly 'System\.TimeOnly')\. This represents the time portion in the offset's time zone\. |
| [ToDateOnly\(this DateTimeOffset\)](DateTimeOffsetExtensions.ToDateOnly.5DJTI5YJCKDCRWGSCHQA5JOD1.md 'DevElf\.Extensions\.DateTimeOffsetExtensions\.ToDateOnly\(this System\.DateTimeOffset\)') | Returns the date component of the provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\. The date portion is taken from the [System\.DateTimeOffset\.Date](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset.date 'System\.DateTimeOffset\.Date') property\. |
| [ToLocalDateOnly\(this DateTimeOffset\)](DateTimeOffsetExtensions.ToLocalDateOnly.9MOVTIQPSF8VLKP71YIJ9VH0F.md 'DevElf\.Extensions\.DateTimeOffsetExtensions\.ToLocalDateOnly\(this System\.DateTimeOffset\)') | Returns the local date component of the provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\. |
| [ToUtcDateOnly\(this DateTimeOffset\)](DateTimeOffsetExtensions.ToUtcDateOnly.8GHFUS2T4LHILJG3WKPW3KX85.md 'DevElf\.Extensions\.DateTimeOffsetExtensions\.ToUtcDateOnly\(this System\.DateTimeOffset\)') | Returns the UTC date component of the provided [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as a [System\.DateOnly](https://learn.microsoft.com/en-us/dotnet/api/system.dateonly 'System\.DateOnly')\. |
