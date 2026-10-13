#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging')

## LoggerExtensions Class

Extension methods for [Microsoft\.Extensions\.Logging\.ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger 'Microsoft\.Extensions\.Logging\.ILogger') to create [ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope') instances\.

```csharp
public static class LoggerExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → LoggerExtensions

| Methods | |
| :--- | :--- |
| [BeginMessageScope\(this ILogger, LogLevel, EventId, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\(this Microsoft\.Extensions\.Logging\.ILogger, Microsoft\.Extensions\.Logging\.LogLevel, Microsoft\.Extensions\.Logging\.EventId, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |
| [BeginMessageScope\(this ILogger, LogLevel, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\(this Microsoft\.Extensions\.Logging\.ILogger, Microsoft\.Extensions\.Logging\.LogLevel, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |
