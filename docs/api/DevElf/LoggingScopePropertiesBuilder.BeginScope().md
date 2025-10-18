#### [DevElf](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder')

## LoggingScopePropertiesBuilder\.BeginScope\(\) Method

Begins a new logging scope with all the properties that have been added\.

```csharp
public System.IDisposable? BeginScope();
```

#### Returns
[System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')  
An [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable') that ends the scope when disposed, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')
if the logger does not support scopes\.

### Example

```csharp
using (logger.AddProperty("UserId", userId)
             .AddProperty("OperationId", operationId)
             .BeginScope())
{
    logger.LogInformation("Operation started");
    // All logs within this scope will include UserId and OperationId
}
```

### Remarks
The returned [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable') should be disposed to properly end the logging scope\.
It's recommended to use this within a [using](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/using') statement to ensure proper cleanup\.