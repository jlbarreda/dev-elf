using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Represents an ambient log message scope.
/// Implementations buffer properties and emit a log entry on <see cref="IDisposable.Dispose"/>.
/// </summary>
public interface ILogMessageScope : IDisposable
{
    /// <summary>
    /// Sets a property on the current scope.
    /// When multiple scopes are nested, child properties override parent properties with the same key.
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    /// <param name="key">The property key. Cannot be <see langword="null"/>, empty, or whitespace.</param>
    /// <param name="value">The property value.</param>
    /// <returns>Returns the provided <paramref name="value"/> to enable fluent assignment.</returns>
    T SetProperty<T>(string key, T value);

    /// <summary>
    /// Sets an <see cref="System.Exception"/> on the scope and also adds it as a scope property under the key "Exception".
    /// </summary>
    /// <param name="setAsProperty">
    /// If <see langword="true"/>, also sets the exception as a property under the key "Exception".
    /// </param>
    /// <param name="exception">The exception to associate with the log entry.</param>
    void SetException(Exception exception, bool setAsProperty = true);

    /// <summary>
    /// Changes the log level that will be used when this scope emits its log entry on dispose.
    /// </summary>
    /// <param name="logLevel">The new log level.</param>
    void ChangeLogLevel(LogLevel logLevel);

    /// <summary>
    /// Changes the <see cref="EventId"/> that will be used when this scope emits its log entry on dispose.
    /// </summary>
    /// <param name="eventId">The new event identifier.</param>
    void ChangeEventId(EventId eventId);

    /// <summary>
    /// Changes the message that will be logged when this scope is disposed.
    /// </summary>
    /// <param name="message">The new message. Cannot be <see langword="null"/>, empty, or whitespace.</param>
    void ChangeMessage(string message);
}
