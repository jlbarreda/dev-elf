using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Extension methods for <see cref="ILogger"/> to integrate with <see cref="LogMessageScope"/>.
/// </summary>
public static class LoggerExtensions
{
    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <typeparam name="TContext">The logger context type.</typeparam>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope<TContext>(this ILogger<TContext> logger, LogLevel logLevel, string message)
        => ((ILogger)logger).BeginMessageScope(logLevel, message);

    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <typeparam name="TContext">The logger context type.</typeparam>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="eventId">The event ID for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope<TContext>(this ILogger<TContext> logger, LogLevel logLevel, EventId eventId, string message)
        => ((ILogger)logger).BeginMessageScope(logLevel, eventId, message);

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
