using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Represents a scope for logging properties. Supports nesting and property accumulation.
/// </summary>
public sealed class LogMessageScope : IDisposable, ILogMessageScope
{
    private static readonly AsyncLocal<Stack<LogMessageScope>?> ScopeStackLocal = new();

    private static Stack<LogMessageScope> ScopeStack
        => ScopeStackLocal.Value ??= new Stack<LogMessageScope>();

    private readonly ConcurrentDictionary<string, object?> _properties = new(StringComparer.OrdinalIgnoreCase);
#pragma warning disable CA2213 // Disposable fields should be disposed => By design. We don't own the parent scope.
    private readonly LogMessageScope? _parent;
#pragma warning restore CA2213 // Disposable fields should be disposed
    private readonly ILogger _logger;

    private LogLevel _logLevel;
    private EventId _eventId;
    private string _message;
    private Exception? _exception;
    private bool _disposed;

    /// <summary>
    /// Creates a new log message scope.
    /// </summary>
    public LogMessageScope(
        ILogger logger,
        LogLevel logLevel,
        EventId eventId,
        string message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);

        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _logLevel = logLevel;
        _eventId = eventId;
        _message = message;

        // Strict LIFO stack management with snapshot of parent for property aggregation.
        var stack = ScopeStack;
        _parent = stack.Count > 0 ? stack.Peek() : null;
        stack.Push(this);
    }

    /// <summary>
    /// Sets a property on this scope.
    /// </summary>
    /// <param name="key">The property key.</param>
    /// <param name="value">The property value.</param>
    public T SetProperty<T>(string key, T value)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentException.ThrowIfNullOrWhiteSpace(key);

        _properties[key] = value;

        return value;
    }

    public void SetException(Exception exception)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentNullException.ThrowIfNull(exception);

        _exception = SetProperty("Exception", exception);
    }

    public void ChangeLogLevel(LogLevel logLevel)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        _logLevel = logLevel;
    }

    public void ChangeEventId(EventId eventId)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        _eventId = eventId;
    }

    public void ChangeMessage(string message)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentException.ThrowIfNullOrWhiteSpace(message);

        _message = message;
    }

    /// <summary>
    /// Disposes the scope and logs the message with accumulated properties.
    /// Enforces strict LIFO disposal using an AsyncLocal-backed stack.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        Stack<LogMessageScope> stack = ScopeStack;

        if (stack.Count == 0 || !ReferenceEquals(stack.Peek(), this))
        {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations => By design. This indicates a programming error.
            throw new InvalidOperationException("LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
        }

        // Pop this scope from the ambient stack
        _ = stack.Pop();

        // Always log on dispose for test compatibility
        Log(GetAllProperties());
    }

    /// <summary>
    /// Gets all properties from this scope and its parents.
    /// </summary>
    private Dictionary<string, object?> GetAllProperties()
    {
        Dictionary<string, object?> properties = _parent?.GetAllProperties() ?? new(StringComparer.OrdinalIgnoreCase);

        foreach (KeyValuePair<string, object?> property in _properties)
        {
            properties[property.Key] = property.Value;
        }

        return properties;
    }

    private void Log(IReadOnlyDictionary<string, object?> properties)
    {
        if (_logger.IsEnabled(_logLevel))
        {
            using (_logger.BeginScope(properties))
            {
#pragma warning disable CA1848 // Use the LoggerMessage delegates
#pragma warning disable CA2254 // Template should be a static expression
                _logger.Log(_logLevel, _eventId, _exception, _message);
#pragma warning restore CA2254 // Template should be a static expression
#pragma warning restore CA1848 // Use the LoggerMessage delegates
            }
        }
    }
}
