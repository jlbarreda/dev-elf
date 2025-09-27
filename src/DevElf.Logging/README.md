# DevElf.Logging

Advanced logging utilities that extend Microsoft.Extensions.Logging with disposable message scopes, property accumulation, and strict LIFO enforcement.

> [!WARNING]
> **This library is currently in development and is not ready for production use.**
> 
> The API is subject to breaking changes without notice. Features may be incomplete or unstable.
> Use at your own risk in non-production environments only.

[![NuGet Version](https://img.shields.io/nuget/v/DevElf.Logging.svg?style=flat-square)](https://www.nuget.org/packages/DevElf.Logging/)

## Features

- **Disposable log message scopes** - Create scopes that log messages when disposed
- **Property accumulation** - Build structured log data across nested scopes
- **Strict LIFO enforcement** - Safety warnings for out-of-order scope disposal
- **Exception handling** - Attach exceptions and modify messages before logging
- **Dynamic log levels** - Change log level and message content before disposal

## Installation

```bash
dotnet add package DevElf.Logging
```

## Quick Start

### Setup Dependency Injection

```csharp
using DevElf.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection()
    .AddLogging(builder => builder.AddConsole())
    .AddLogMessageScopes(); // Register log message scope services

var provider = services.BuildServiceProvider();
var logger = provider.GetRequiredService<ILogger<MyService>>();
```

### Basic Usage

```csharp
using var scope = logger.BeginMessageScope(LogLevel.Information, "Processing user request");
scope.SetProperty("UserId", userId);
scope.SetProperty("RequestId", requestId);

// Do work...

// Message is logged on dispose with all accumulated properties
```

### Advanced Usage with Exception Handling

```csharp
using var scope = logger.BeginMessageScope(LogLevel.Information, new EventId(1001, "DataImport"), "Starting data import");
scope.SetProperty("FileName", fileName);
scope.SetProperty("CorrelationId", correlationId);

try
{
    // Perform import operation
    var recordCount = await ImportDataAsync(fileName);
    scope.SetProperty("RecordCount", recordCount);
}
catch (Exception ex)
{
    scope.SetException(ex, setProperty: true); // Adds exception as property and sets Exception
    scope.ChangeLogLevel(LogLevel.Error);      // Change from Information to Error
    scope.ChangeMessage("Data import failed"); // Update the message
    throw;
}
// Logs either success or failure message with all properties
```

### Nested Scopes

```csharp
using var outerScope = logger.BeginMessageScope(LogLevel.Information, "Processing batch");
outerScope.SetProperty("BatchId", batchId);
outerScope.SetProperty("Environment", "Production");

foreach (var item in batch)
{
    using var innerScope = logger.BeginMessageScope(LogLevel.Debug, "Processing item");
    innerScope.SetProperty("ItemId", item.Id);
    innerScope.SetProperty("Environment", "Staging"); // Overrides parent value
    
    // Process item...
    
    // Inner scope logs with: BatchId, ItemId, Environment="Staging"
}

// Outer scope logs with: BatchId, Environment="Production"
```

## API Reference

### ILogMessageScope

| Method | Description |
|--------|-------------|
| `SetProperty(string key, object? value)` | Add or update a property in the scope |
| `SetException(Exception exception, bool setProperty = false)` | Attach an exception to log on dispose |
| `ChangeLogLevel(LogLevel logLevel)` | Change the log level for the final message |
| `ChangeMessage(string message)` | Change the message text to log on dispose |
| `ChangeEventId(EventId eventId)` | Change the event ID for the final message |

### Logger Extensions

| Method | Description |
|--------|-------------|
| `BeginMessageScope(LogLevel, string)` | Create a basic message scope |
| `BeginMessageScope(LogLevel, EventId, string)` | Create a message scope with event ID |

## Important Notes

> [!WARNING]
> **LIFO Disposal Required**: Log message scopes must be disposed in Last-In-First-Out (LIFO) order. Disposing out of order logs a warning and the disposal is ignored, allowing a later correct disposal to succeed.

> [!IMPORTANT]
> **Property Inheritance**: Properties from outer scopes are inherited by inner scopes. When property keys conflict, the innermost scope value takes precedence.

## Requirements

- .NET 10.0+
- Microsoft.Extensions.Logging.Abstractions

## Dependencies

- **DevElf** - Core argument validation utilities

## License

This project is licensed under the MIT License.
