#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging')

## LogMessageScopeAccessor Class

Provides access to the current [log message scope](https://learn.microsoft.com/en-us/dotnet/api/develf.logging.logmessagescope 'DevElf\.Logging\.LogMessageScope')\.

```csharp
public sealed class LogMessageScopeAccessor : DevElf.Logging.ILogMessageScopeAccessor
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; LogMessageScopeAccessor

Implements [ILogMessageScopeAccessor](ILogMessageScopeAccessor.md 'DevElf\.Logging\.ILogMessageScopeAccessor')

| Properties | |
| :--- | :--- |
| [Current](LogMessageScopeAccessor.Current.md 'DevElf\.Logging\.LogMessageScopeAccessor\.Current') | Gets the current [ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when no scope is active\. |
