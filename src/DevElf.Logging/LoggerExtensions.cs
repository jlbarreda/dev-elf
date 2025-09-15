using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Extension methods for <see cref="ILogger"/> to integrate with <see cref="LogMessageScope"/>.
/// </summary>
public static class LoggerExtensions
{
    private static readonly LogMessageScopeFactory DefaultFactory = new();

    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, LogLevel logLevel, string message)
        => DefaultFactory.Create(logger, logLevel, message);

    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="eventId">The event ID for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, LogLevel logLevel, EventId eventId, string message)
        => DefaultFactory.Create(logger, logLevel, eventId, message);

    /// <summary>
    /// Creates a new log message scope that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <typeparam name="TContext">The logger context type.</typeparam>
    /// <param name="logger">The logger instance.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope<TContext>(this ILogger<TContext> logger, LogLevel logLevel, string message)
        => DefaultFactory.Create(logger, logLevel, message);

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
        => DefaultFactory.Create(logger, logLevel, eventId, message);

    /// <summary>
    /// Creates a new log message scope using a custom factory that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="factory">The scope factory to use.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, ILogMessageScopeFactory factory, LogLevel logLevel, string message)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return factory.Create(logger, logLevel, message);
    }

    /// <summary>
    /// Creates a new log message scope using a custom factory that integrates with Microsoft's logging infrastructure.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="factory">The scope factory to use.</param>
    /// <param name="logLevel">The log level for the scope.</param>
    /// <param name="eventId">The event ID for the scope.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A new log message scope.</returns>
    public static ILogMessageScope BeginMessageScope(this ILogger logger, ILogMessageScopeFactory factory, LogLevel logLevel, EventId eventId, string message)
    {
        ArgumentNullException.ThrowIfNull(factory);
        return factory.Create(logger, logLevel, eventId, message);
    }
}