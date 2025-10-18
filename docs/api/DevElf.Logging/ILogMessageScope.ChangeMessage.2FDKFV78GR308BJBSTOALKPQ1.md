#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')

## ILogMessageScope\.ChangeMessage\(string\) Method

Changes the message that will be logged when this scope is disposed\.

```csharp
void ChangeMessage(string message);
```
#### Parameters

<a name='DevElf.Logging.ILogMessageScope.ChangeMessage(string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new message\. Cannot be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), empty, or whitespace\.