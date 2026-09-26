#### [DevElf](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging')

## LoggingScopePropertiesBuilder Class

Provides a fluent API for building logging scopes with multiple properties\.

```csharp
public sealed class LoggingScopePropertiesBuilder
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; LoggingScopePropertiesBuilder

### Remarks
This class is typically created using the [AddProperty\(this ILogger, string, object\)](LoggerExtensions.AddProperty.3HF6MS7LG9TTAZCXIBRQIVMY8.md 'DevElf\.Logging\.LoggerExtensions\.AddProperty\(this Microsoft\.Extensions\.Logging\.ILogger, string, object\)') extension method
and allows chaining multiple property additions before beginning the scope\.

| Methods | |
| :--- | :--- |
| [AddProperty\(string, object\)](LoggingScopePropertiesBuilder.AddProperty.ECT6GIFQ7YQ2WQEOEILC883U4.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.AddProperty\(string, object\)') | Adds or updates a property in the logging scope\. |
| [BeginScope\(\)](LoggingScopePropertiesBuilder.BeginScope().md 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.BeginScope\(\)') | Begins a new logging scope with all the properties that have been added\. |
