#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[LoggerExtensions](LoggerExtensions.md 'DevElf\.Logging\.LoggerExtensions')

## LoggerExtensions\.BeginMessageScope Method

| Overloads | |
| :--- | :--- |
| [BeginMessageScope\(this ILogger, LogLevel, EventId, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\(this Microsoft\.Extensions\.Logging\.ILogger, Microsoft\.Extensions\.Logging\.LogLevel, Microsoft\.Extensions\.Logging\.EventId, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |
| [BeginMessageScope\(this ILogger, LogLevel, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\(this Microsoft\.Extensions\.Logging\.ILogger, Microsoft\.Extensions\.Logging\.LogLevel, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |
| [BeginMessageScope&lt;TContext&gt;\(this ILogger&lt;TContext&gt;, LogLevel, EventId, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\<TContext\>\(this Microsoft\.Extensions\.Logging\.ILogger\<TContext\>, Microsoft\.Extensions\.Logging\.LogLevel, Microsoft\.Extensions\.Logging\.EventId, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |
| [BeginMessageScope&lt;TContext&gt;\(this ILogger&lt;TContext&gt;, LogLevel, string\)](LoggerExtensions.BeginMessageScope.md#DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string) 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\<TContext\>\(this Microsoft\.Extensions\.Logging\.ILogger\<TContext\>, Microsoft\.Extensions\.Logging\.LogLevel, string\)') | Creates a new log message scope that integrates with Microsoft's logging infrastructure\. |

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string)'></a>

## LoggerExtensions\.BeginMessageScope\(this ILogger, LogLevel, EventId, string\) Method

Creates a new log message scope that integrates with Microsoft's logging infrastructure\.

```csharp
public static DevElf.Logging.ILogMessageScope BeginMessageScope(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string message);
```
#### Parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).logger'></a>

`logger` [Microsoft\.Extensions\.Logging\.ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger 'Microsoft\.Extensions\.Logging\.ILogger')

The logger instance\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).logLevel'></a>

`logLevel` [Microsoft\.Extensions\.Logging\.LogLevel](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loglevel 'Microsoft\.Extensions\.Logging\.LogLevel')

The log level for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).eventId'></a>

`eventId` [Microsoft\.Extensions\.Logging\.EventId](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.eventid 'Microsoft\.Extensions\.Logging\.EventId')

The event ID for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The log message\.

#### Returns
[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')  
A new log message scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string)'></a>

## LoggerExtensions\.BeginMessageScope\(this ILogger, LogLevel, string\) Method

Creates a new log message scope that integrates with Microsoft's logging infrastructure\.

```csharp
public static DevElf.Logging.ILogMessageScope BeginMessageScope(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, string message);
```
#### Parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string).logger'></a>

`logger` [Microsoft\.Extensions\.Logging\.ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger 'Microsoft\.Extensions\.Logging\.ILogger')

The logger instance\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string).logLevel'></a>

`logLevel` [Microsoft\.Extensions\.Logging\.LogLevel](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loglevel 'Microsoft\.Extensions\.Logging\.LogLevel')

The log level for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope(thisMicrosoft.Extensions.Logging.ILogger,Microsoft.Extensions.Logging.LogLevel,string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The log message\.

#### Returns
[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')  
A new log message scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string)'></a>

## LoggerExtensions\.BeginMessageScope\<TContext\>\(this ILogger\<TContext\>, LogLevel, EventId, string\) Method

Creates a new log message scope that integrates with Microsoft's logging infrastructure\.

```csharp
public static DevElf.Logging.ILogMessageScope BeginMessageScope<TContext>(this Microsoft.Extensions.Logging.ILogger<TContext> logger, Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string message);
```
#### Type parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).TContext'></a>

`TContext`

The logger context type\.
#### Parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).logger'></a>

`logger` [Microsoft\.Extensions\.Logging\.ILogger&lt;](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1 'Microsoft\.Extensions\.Logging\.ILogger\`1')[TContext](LoggerExtensions.md#DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).TContext 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\<TContext\>\(this Microsoft\.Extensions\.Logging\.ILogger\<TContext\>, Microsoft\.Extensions\.Logging\.LogLevel, Microsoft\.Extensions\.Logging\.EventId, string\)\.TContext')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1 'Microsoft\.Extensions\.Logging\.ILogger\`1')

The logger instance\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).logLevel'></a>

`logLevel` [Microsoft\.Extensions\.Logging\.LogLevel](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loglevel 'Microsoft\.Extensions\.Logging\.LogLevel')

The log level for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).eventId'></a>

`eventId` [Microsoft\.Extensions\.Logging\.EventId](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.eventid 'Microsoft\.Extensions\.Logging\.EventId')

The event ID for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The log message\.

#### Returns
[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')  
A new log message scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string)'></a>

## LoggerExtensions\.BeginMessageScope\<TContext\>\(this ILogger\<TContext\>, LogLevel, string\) Method

Creates a new log message scope that integrates with Microsoft's logging infrastructure\.

```csharp
public static DevElf.Logging.ILogMessageScope BeginMessageScope<TContext>(this Microsoft.Extensions.Logging.ILogger<TContext> logger, Microsoft.Extensions.Logging.LogLevel logLevel, string message);
```
#### Type parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string).TContext'></a>

`TContext`

The logger context type\.
#### Parameters

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string).logger'></a>

`logger` [Microsoft\.Extensions\.Logging\.ILogger&lt;](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1 'Microsoft\.Extensions\.Logging\.ILogger\`1')[TContext](LoggerExtensions.md#DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string).TContext 'DevElf\.Logging\.LoggerExtensions\.BeginMessageScope\<TContext\>\(this Microsoft\.Extensions\.Logging\.ILogger\<TContext\>, Microsoft\.Extensions\.Logging\.LogLevel, string\)\.TContext')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1 'Microsoft\.Extensions\.Logging\.ILogger\`1')

The logger instance\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string).logLevel'></a>

`logLevel` [Microsoft\.Extensions\.Logging\.LogLevel](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.loglevel 'Microsoft\.Extensions\.Logging\.LogLevel')

The log level for the scope\.

<a name='DevElf.Logging.LoggerExtensions.BeginMessageScope_TContext_(thisMicrosoft.Extensions.Logging.ILogger_TContext_,Microsoft.Extensions.Logging.LogLevel,string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The log message\.

#### Returns
[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')  
A new log message scope\.