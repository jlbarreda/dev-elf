#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging')

## ILogMessageScope Interface

Represents an ambient log message scope\.
Implementations buffer properties and emit a log entry on [System\.IDisposable\.Dispose](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')\.

```csharp
public interface ILogMessageScope : System.IDisposable
```

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')

| Methods | |
| :--- | :--- |
| [ChangeEventId\(EventId\)](ILogMessageScope.ChangeEventId.2II91DHU6UBPX38ZVB3F7A973.md 'DevElf\.Logging\.ILogMessageScope\.ChangeEventId\(Microsoft\.Extensions\.Logging\.EventId\)') | Changes the [Microsoft\.Extensions\.Logging\.EventId](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.eventid 'Microsoft\.Extensions\.Logging\.EventId') that will be used when this scope emits its log entry on dispose\. |
| [ChangeLogLevel\(LogLevel\)](ILogMessageScope.ChangeLogLevel.T8V2CVT94S8T3JEG5QV4IHR23.md 'DevElf\.Logging\.ILogMessageScope\.ChangeLogLevel\(Microsoft\.Extensions\.Logging\.LogLevel\)') | Changes the log level that will be used when this scope emits its log entry on dispose\. |
| [ChangeMessage\(string\)](ILogMessageScope.ChangeMessage.2FDKFV78GR308BJBSTOALKPQ1.md 'DevElf\.Logging\.ILogMessageScope\.ChangeMessage\(string\)') | Changes the message that will be logged when this scope is disposed\. |
| [SetException\(Exception, bool\)](ILogMessageScope.SetException.RD4VYIJ1SQ9EVWX51XVKJSNO7.md 'DevElf\.Logging\.ILogMessageScope\.SetException\(System\.Exception, bool\)') | Sets an [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') on the scope and also adds it as a scope property under the key "Exception"\. |
| [SetProperty&lt;T&gt;\(string, T\)](ILogMessageScope.SetProperty.W33WIH8SSDTY69PIOC9JED2Q2.md 'DevElf\.Logging\.ILogMessageScope\.SetProperty\<T\>\(string, T\)') | Sets a property on the current scope\. When multiple scopes are nested, child properties override parent properties with the same key\. |
