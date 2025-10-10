using System.Collections.Concurrent;
using DevElf.ArgumentValidation;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Represents a scope for logging properties. Supports nesting and property accumulation.
/// </summary>
/// <remarks>
/// A <see cref="LogMessageScope"/> is pushed onto an async-local stack when constructed and
/// popped when disposed. Scopes must be disposed in LIFO order. If a scope is disposed out of order,
/// a warning is logged and no state is changed, allowing a later correct dispose to succeed.
///
/// While active, a scope can accumulate key/value properties via <see cref="SetProperty{T}(string, T)"/>.
/// When scopes are nested, properties are merged so that child properties override parent values for the
/// same key. On <see cref="Dispose"/>, the scope logs its message at the configured <see cref="LogLevel"/>, 
/// using <see cref="ILogger.BeginScope{TState}(TState)"/> with the accumulated properties so they are available to
/// logging providers that support scopes.
///
/// An exception can be associated to the log entry via <see cref="SetException(Exception, bool)"/> and will be
/// passed to the logger when the scope is disposed. When <c>setAsProperty</c> is
/// <see langword="true"/>, the exception is also added as a scope property under the key "Exception".
/// </remarks>
internal sealed partial class LogMessageScope : IDisposable, ILogMessageScope
{
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
    /// Initializes a new instance of the <see cref="LogMessageScope"/> class and pushes it onto the
    /// ambient async-local scope stack.
    /// </summary>
    /// <param name="logger">The logger used to emit the message when the scope is disposed.</param>
    /// <param name="logLevel">The log level for the message.</param>
    /// <param name="eventId">The event identifier for the message.</param>
    /// <param name="message">The message to log when the scope is disposed.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="logger"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="logLevel"/> is not a defined value.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="message"/> is <see langword="null"/>, empty, or whitespace.</exception>
    public LogMessageScope(
        ILogger logger,
        LogLevel logLevel,
        EventId eventId,
        string message)
    {
        logLevel.ThrowIfNotDefined();
        message.ThrowIfNullOrWhiteSpace();

        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _logLevel = logLevel;
        _eventId = eventId;
        _message = message;

        _parent = AsyncLocalLogMessageScopeStack.Peek();
        AsyncLocalLogMessageScopeStack.Push(this);
    }

    /// <summary>
    /// Sets a property on this scope.
    /// </summary>
    /// <param name="key">The property key.</param>
    /// <param name="value">The property value.</param>
    /// <typeparam name="T">The value type.</typeparam>
    /// <returns>Returns the provided <paramref name="value"/> to enable fluent assignment.</returns>
    public T SetProperty<T>(string key, T value)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        key.ThrowIfNullOrWhiteSpace();

        _properties[key] = value;

        return value;
    }

    /// <summary>
    /// Sets an exception for this scope and optionally adds it as a property.
    /// </summary>
    /// <param name="exception">The exception to set.</param>
    /// <param name="setProperty">
    /// If <see langword="true"/>, also sets the exception as a property under the key "Exception".
    /// </param>
    public void SetException(Exception exception, bool setProperty = false)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        exception.ThrowIfNull();

        _exception = setProperty ? SetProperty(nameof(Exception), exception) : exception;
    }

    /// <summary>
    /// Changes the log level for this scope.
    /// </summary>
    /// <param name="logLevel">The new log level.</param>
    public void ChangeLogLevel(LogLevel logLevel)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        logLevel.ThrowIfNotDefined();

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
        message.ThrowIfNullOrWhiteSpace();

        _message = message;
    }

    /// <summary>
    /// Disposes the scope and logs the message with accumulated properties.
    /// Enforces strict LIFO disposal using the ambient async-local stack.
    /// If the scope is disposed out of order, it logs a warning and returns without changing state.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        // Validate LIFO without marking disposed; allow a later correct dispose to succeed.
        if (AsyncLocalLogMessageScopeStack.Count == 0 || !ReferenceEquals(AsyncLocalLogMessageScopeStack.Peek(), this))
        {
            LogOutOfOrderDisposeWarning();

            return;
        }

        // Pop first to update the ambient stack to the parent before logging.
        _ = AsyncLocalLogMessageScopeStack.Pop();

        // Log with accumulated properties from this scope and its parents
        Log(GetAllProperties());

        // Finally mark as disposed
        _disposed = true;
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

    [LoggerMessage(
        Level = LogLevel.Warning,
        Message = "LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.")]
    private partial void LogOutOfOrderDisposeWarning();
}
