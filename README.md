<p align="center">
  <picture>
    <img src="./assets/Logo.png" alt="DevElf logo" width="200" />
  </picture>
</p>

# DevElf

Essential .NET libraries that make day-to-day development simpler and safer.

- Core utilities for argument validation and fluent string checks
- Logging helpers with disposable message scopes, property accumulation, and strict LIFO enforcement

> [!NOTE]
> This repository targets .NET 10.0.

[![NuGet Version](https://img.shields.io/nuget/v/DevElf.svg?style=flat-square)](https://www.nuget.org/packages/DevElf/)

[![NuGet Version](https://img.shields.io/nuget/v/DevElf.Logging.svg?style=flat-square)](https://www.nuget.org/packages/DevElf.Logging/)

[![Build Status](https://github.com/jlbarreda/DevElf/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/jlbarreda/DevElf/actions/workflows/ci-cd.yml)

[![License](https://img.shields.io/github/license/jlbarreda/DevElf.svg?style=flat-square)](https://github.com/jlbarreda/DevElf/blob/main/LICENSE)

## Features

- Argument validation:
  - `ThrowIfNull`, `ThrowIfNullOrEmpty`, `ThrowIfNullOrWhiteSpace`
  - `ThrowIfNotDefined` for enums
- Nullable string helpers:
  - `IsNull`, `IsNullOrEmpty`, `IsNullOrWhiteSpace`
- Logging scopes:
  - `ILogger.BeginMessageScope(...)` returning an `ILogMessageScope`
  - Accumulate properties across nested scopes (child overrides parent)
  - Attach exceptions and change level/message/event id before dispose
  - Strict LIFO dispose with safety warning if out-of-order

> [!WARNING]
> Log message scopes must be disposed in LIFO order. Disposing out of order logs a warning and is ignored
> so a later correct dispose can succeed.

## Requirements

- .NET SDK 10.0+

## Quick start

Build all projects:

```bash
dotnet build
```

Run tests:

```bash
dotnet test
```

## Usage

### Argument validation

```csharp
using DevElf.ArgumentValidation;

void Process(string name, DayOfWeek day)
{
    name.ThrowIfNullOrWhiteSpace();  // throws if null/empty/whitespace
    day.ThrowIfNotDefined();         // throws if undefined enum value

    // ... your logic
}
```

### Nullable string helpers

```csharp
using DevElf.Extensions;

string? input = GetInput();
if (input.IsNullOrWhiteSpace())
{
    // handle missing value
}
```

### Logging message scopes

```csharp
using DevElf.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// Register once at startup
var services = new ServiceCollection()
    .AddLogging(b => b.AddConsole())
    .AddLogMessageScopes();

var provider = services.BuildServiceProvider();
var logger = provider.GetRequiredService<ILogger<Program>>();

// Use a disposable message scope that logs on dispose
using (var scope = logger.BeginMessageScope(LogLevel.Information, new EventId(1001, "Import"), "Import completed"))
{
    scope.SetProperty("CorrelationId", Guid.NewGuid());

    try
    {
        // ... do work
    }
    catch (Exception ex)
    {
        scope.SetException(ex, setProperty: true);
        scope.ChangeLogLevel(LogLevel.Error);
        scope.ChangeMessage("Import failed");

        throw;
    }
} // message written here with accumulated properties
```

> [!IMPORTANT]
> Properties set on nested scopes are merged. When keys conflict, the innermost scope value wins.
