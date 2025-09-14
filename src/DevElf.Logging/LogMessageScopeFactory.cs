using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

public class LogMessageScopeFactory : ILogMessageScopeFactory
{
    public ILogMessageScope Create(ILogger logger, LogLevel logLevel, string message)
        => Create(logger, logLevel, 0, message);

    public ILogMessageScope Create(ILogger logger, LogLevel logLevel, EventId eventId, string message)
        => new LogMessageScope(logger, logLevel, eventId, message);

    public ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, string message)
        => Create(logger, logLevel, 0, message);

    public ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, EventId eventId, string message)
        => new LogMessageScope(logger, logLevel, eventId, message);
}
