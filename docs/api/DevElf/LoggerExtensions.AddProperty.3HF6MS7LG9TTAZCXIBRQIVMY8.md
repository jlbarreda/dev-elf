#### [DevElf](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[LoggerExtensions](LoggerExtensions.md 'DevElf\.Logging\.LoggerExtensions')

## LoggerExtensions\.AddProperty\(this ILogger, string, object\) Method

Creates a new logging scope properties builder with the specified property\.

```csharp
public static DevElf.Logging.LoggingScopePropertiesBuilder AddProperty(this Microsoft.Extensions.Logging.ILogger logger, string name, object? value);
```
#### Parameters

<a name='DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).logger'></a>

`logger` [Microsoft\.Extensions\.Logging\.ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger 'Microsoft\.Extensions\.Logging\.ILogger')

The logger instance to create a scope for\.

<a name='DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property to add to the logging scope\.

<a name='DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value of the property to add to the logging scope\.

#### Returns
[LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder')  
A [LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder') that can be used to add more properties
or begin the logging scope\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [logger](LoggerExtensions.AddProperty.3HF6MS7LG9TTAZCXIBRQIVMY8.md#DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).logger 'DevElf\.Logging\.LoggerExtensions\.AddProperty\(this Microsoft\.Extensions\.Logging\.ILogger, string, object\)\.logger') or [name](LoggerExtensions.AddProperty.3HF6MS7LG9TTAZCXIBRQIVMY8.md#DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).name 'DevElf\.Logging\.LoggerExtensions\.AddProperty\(this Microsoft\.Extensions\.Logging\.ILogger, string, object\)\.name') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown when [name](LoggerExtensions.AddProperty.3HF6MS7LG9TTAZCXIBRQIVMY8.md#DevElf.Logging.LoggerExtensions.AddProperty(thisMicrosoft.Extensions.Logging.ILogger,string,object).name 'DevElf\.Logging\.LoggerExtensions\.AddProperty\(this Microsoft\.Extensions\.Logging\.ILogger, string, object\)\.name') is empty or contains only whitespace\.

### Example

```csharp
using (logger.AddProperty("UserId", userId)
             .AddProperty("RequestId", requestId)
             .BeginScope())
{
    logger.LogInformation("Processing request");
}
```

### Remarks
This method provides a fluent API for building logging scopes with multiple properties\.
Use the returned builder to add additional properties via [AddProperty\(string, object\)](LoggingScopePropertiesBuilder.AddProperty.ECT6GIFQ7YQ2WQEOEILC883U4.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.AddProperty\(string, object\)')
and then call [BeginScope\(\)](LoggingScopePropertiesBuilder.BeginScope().md 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.BeginScope\(\)') to create the scope\.