#### [DevElf\.Logging](README.md 'README')

## DevElf\.Logging Namespace

| Classes | |
| :--- | :--- |
| [LoggerExtensions](LoggerExtensions.md 'DevElf\.Logging\.LoggerExtensions') | Extension methods for [Microsoft\.Extensions\.Logging\.ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger 'Microsoft\.Extensions\.Logging\.ILogger') to integrate with [DevElf\.Logging\.LogMessageScope](https://learn.microsoft.com/en-us/dotnet/api/develf.logging.logmessagescope 'DevElf\.Logging\.LogMessageScope')\. |
| [LogMessageScopeAccessor](LogMessageScopeAccessor.md 'DevElf\.Logging\.LogMessageScopeAccessor') | Provides access to the current [log message scope](https://learn.microsoft.com/en-us/dotnet/api/develf.logging.logmessagescope 'DevElf\.Logging\.LogMessageScope')\. |
| [ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.Logging\.ServiceCollectionExtensions') | Extension methods for configuring log message scope services in dependency injection\. |

| Interfaces | |
| :--- | :--- |
| [ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope') | Represents an ambient log message scope\. Implementations buffer properties and emit a log entry on [System\.IDisposable\.Dispose](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')\. |
| [ILogMessageScopeAccessor](ILogMessageScopeAccessor.md 'DevElf\.Logging\.ILogMessageScopeAccessor') | Provides access to the current [ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')\. |
