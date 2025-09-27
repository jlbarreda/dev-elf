# DevElf

Essential .NET utilities for argument validation and string handling that make day-to-day development simpler and safer.

> [!WARNING]
> **This library is currently in development and is not ready for production use.**
> 
> The API is subject to breaking changes without notice. Features may be incomplete or unstable.
> Use at your own risk in non-production environments only.

[![NuGet Version](https://img.shields.io/nuget/v/DevElf.svg?style=flat-square)](https://www.nuget.org/packages/DevElf/)

## Features

- **Argument validation extensions** - Fluent validation methods that throw appropriate exceptions
- **Nullable string helpers** - Readable extension methods for common string null/empty checks

## Installation

```bash
dotnet add package DevElf
```

## Quick Start

### Argument Validation

```csharp
using DevElf.ArgumentValidation;

void ProcessData(string name, int? id, DayOfWeek day)
{
    name.ThrowIfNullOrWhiteSpace();     // throws ArgumentException if null/empty/whitespace
    id.ThrowIfNull();                   // throws ArgumentNullException if null
    day.ThrowIfNotDefined();            // throws ArgumentException if undefined enum value

    // Safe to use validated parameters
}
```

### String Extensions

```csharp
using DevElf.Extensions;

string? input = GetUserInput();

if (input.IsNullOrWhiteSpace())
{
    Console.WriteLine("Please provide valid input");
    return;
}

// input is guaranteed to have content
ProcessInput(input);
```

## API Reference

### Argument Validation Extensions

| Method | Description |
|--------|-------------|
| `ThrowIfNull<T>(this T? value)` | Throws `ArgumentNullException` if value is null |
| `ThrowIfNullOrEmpty(this string? value)` | Throws `ArgumentException` if string is null or empty |
| `ThrowIfNullOrWhiteSpace(this string? value)` | Throws `ArgumentException` if string is null, empty, or whitespace |
| `ThrowIfNotDefined<T>(this T value)` where T : Enum | Throws `ArgumentException` if enum value is not defined |

### String Extensions

| Method | Description |
|--------|-------------|
| `IsNull(this string? text)` | Returns `true` if string is null |
| `IsNullOrEmpty(this string? text)` | Returns `true` if string is null or empty |
| `IsNullOrWhiteSpace(this string? text)` | Returns `true` if string is null, empty, or whitespace |

All string extension methods are annotated with `[NotNullWhen(false)]` for improved nullable reference type support.

## Requirements

- .NET 10.0+

## Related Packages

- **DevElf.Logging** - Advanced logging scopes and message accumulation

## License

This project is licensed under the MIT License.
