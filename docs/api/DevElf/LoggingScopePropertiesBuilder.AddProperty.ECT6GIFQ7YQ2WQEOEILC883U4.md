#### [DevElf](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder')

## LoggingScopePropertiesBuilder\.AddProperty\(string, object\) Method

Adds or updates a property in the logging scope\.

```csharp
public DevElf.Logging.LoggingScopePropertiesBuilder AddProperty(string name, object? value);
```
#### Parameters

<a name='DevElf.Logging.LoggingScopePropertiesBuilder.AddProperty(string,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property to add or update\.

<a name='DevElf.Logging.LoggingScopePropertiesBuilder.AddProperty(string,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value of the property\.

#### Returns
[LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder')  
The current [LoggingScopePropertiesBuilder](LoggingScopePropertiesBuilder.md 'DevElf\.Logging\.LoggingScopePropertiesBuilder') instance for method chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [name](LoggingScopePropertiesBuilder.AddProperty.ECT6GIFQ7YQ2WQEOEILC883U4.md#DevElf.Logging.LoggingScopePropertiesBuilder.AddProperty(string,object).name 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.AddProperty\(string, object\)\.name') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown when [name](LoggingScopePropertiesBuilder.AddProperty.ECT6GIFQ7YQ2WQEOEILC883U4.md#DevElf.Logging.LoggingScopePropertiesBuilder.AddProperty(string,object).name 'DevElf\.Logging\.LoggingScopePropertiesBuilder\.AddProperty\(string, object\)\.name') is empty or contains only whitespace\.

### Remarks
If a property with the same name already exists, its value will be replaced with the new value\.