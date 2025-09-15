using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Represents a scope for logging properties. Supports nesting and property accumulation.
/// </summary>
public sealed class LogMessageScope : IDisposable, ILogMessageScope
{
    private readonly ILogMessageScopeStore<LogMessageScope> _ambientStack;

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

    // Microsoft logging scope integration
    private IDisposable? _microsoftScope;
    private readonly object _scopeLock = new();

    /// <summary>
    /// Creates a new log message scope.
    /// </summary>
    public LogMessageScope(
        ILogMessageScopeStore<LogMessageScope> ambientStack,
        ILogger logger,
        LogLevel logLevel,
        EventId eventId,
        string message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);

        _ambientStack = ambientStack ?? throw new ArgumentNullException(nameof(ambientStack));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _logLevel = logLevel;
        _eventId = eventId;
        _message = message;

        _parent = _ambientStack.Peek();
        _ambientStack.Push(this);
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
        UpdateMicrosoftScope();

        return value;
    }

    /// <summary>
    /// Sets an exception for this scope and adds it as a property.
    /// </summary>
    /// <param name="exception">The exception to set.</param>
    public void SetException(Exception exception)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentNullException.ThrowIfNull(exception);

        _exception = SetProperty("Exception", exception);
    }

    /// <summary>
    /// Changes the log level for this scope.
    /// </summary>
    /// <param name="logLevel">The new log level.</param>
    public void ChangeLogLevel(LogLevel logLevel)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        _logLevel = logLevel;
    }

    /// <summary>
    /// Changes the event ID for this scope.
    /// </summary>
    /// <param name="eventId">The new event ID.</param>
    public void ChangeEventId(EventId eventId)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        _eventId = eventId;
    }

    /// <summary>
    /// Changes the message for this scope.
    /// </summary>
    /// <param name="message">The new message.</param>
    public void ChangeMessage(string message)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentException.ThrowIfNullOrWhiteSpace(message);

        _message = message;
    }

    /// <summary>
    /// Updates the Microsoft logging scope with current properties.
    /// This ensures that properties are visible to the Microsoft logging infrastructure immediately.
    /// </summary>
    private void UpdateMicrosoftScope()
    {
        lock (_scopeLock)
        {
            // Dispose the previous scope if it exists
            _microsoftScope?.Dispose();

            // Create a new scope with all current properties
            Dictionary<string, object?> allProperties = GetAllProperties();
            
            if (allProperties.Count > 0)
            {
                _microsoftScope = _logger.BeginScope(allProperties);
            }
        }
    }

    /// <summary>
    /// Disposes the scope and logs the message with accumulated properties.
    /// Enforces strict LIFO disposal using the injected ambient stack.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        if (_ambientStack.Count == 0 || !ReferenceEquals(_ambientStack.Peek(), this))
        {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations => By design. This indicates a programming error.
            throw new InvalidOperationException("LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
        }

        _ = _ambientStack.Pop();

        // Dispose the Microsoft scope first
        lock (_scopeLock)
        {
            _microsoftScope?.Dispose();
            _microsoftScope = null;
        }

        Log(GetAllProperties());
    }

    /// <summary>
    /// Gets all properties from this scope and its parents.
    /// </summary>
    private Dictionary<string, object?> GetAllProperties()
    {
        Dictionary<string, object?> parentProperties = _parent?.GetAllProperties() ?? new(StringComparer.OrdinalIgnoreCase);

        foreach (KeyValuePair<string, object?> property in _properties)
        {
            parentProperties[property.Key] = property.Value;
        }

        return parentProperties;
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
