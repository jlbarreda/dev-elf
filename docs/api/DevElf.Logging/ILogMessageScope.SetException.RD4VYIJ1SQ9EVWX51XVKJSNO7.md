#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')

## ILogMessageScope\.SetException\(Exception, bool\) Method

Sets an [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') on the scope and also adds it as a scope property under the key "Exception"\.

```csharp
void SetException(System.Exception exception, bool setAsProperty=true);
```
#### Parameters

<a name='DevElf.Logging.ILogMessageScope.SetException(System.Exception,bool).exception'></a>

`exception` [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

The exception to associate with the log entry\.

<a name='DevElf.Logging.ILogMessageScope.SetException(System.Exception,bool).setAsProperty'></a>

`setAsProperty` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), also sets the exception as a property under the key "Exception"\.