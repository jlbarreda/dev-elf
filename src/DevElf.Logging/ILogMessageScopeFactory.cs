using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

public interface ILogMessageScopeFactory
{
    ILogMessageScope Create(ILogger logger, LogLevel logLevel, string message);

    ILogMessageScope Create(ILogger logger, LogLevel logLevel, EventId eventId, string message);

    ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, string message);

    ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, EventId eventId, string message);
}
