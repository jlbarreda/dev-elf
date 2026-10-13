using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Extension methods for <see cref="ILogger"/> to create <see cref="ILogMessageScope"/> instances.
/// </summary>
public static class LoggerExtensions
{
    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, LogLevel logLevel, string message)
        => logger.BeginMessageScope(logLevel, 0, message);

    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="eventId">The event ID for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, LogLevel logLevel, EventId eventId, string message)
        => new LogMessageScope(logger, logLevel, eventId, message);
}
