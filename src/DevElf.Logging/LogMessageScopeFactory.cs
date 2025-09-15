using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

public class LogMessageScopeFactory : ILogMessageScopeFactory
{
    private readonly ILogMessageScopeStore<LogMessageScope> _ambientStack;
    private readonly IExternalScopeIntegration? _externalScopeIntegration;

    public LogMessageScopeFactory()
        : this(new LogMessageScopeStore<LogMessageScope>())
    {
    }

    public LogMessageScopeFactory(ILogMessageScopeStore<LogMessageScope> ambientStack)
        : this(ambientStack, null)
    {
    }

    public LogMessageScopeFactory(ILogMessageScopeStore<LogMessageScope> ambientStack, IExternalScopeIntegration? externalScopeIntegration)
    {
        _ambientStack = ambientStack ?? throw new ArgumentNullException(nameof(ambientStack));
        _externalScopeIntegration = externalScopeIntegration;
    }

    public ILogMessageScope Create(ILogger logger, LogLevel logLevel, string message)
        => Create(logger, logLevel, 0, message);

    public ILogMessageScope Create(ILogger logger, LogLevel logLevel, EventId eventId, string message)
    {
        LogMessageScope scope = new(_ambientStack, logger, logLevel, eventId, message);

        // Integrate external scope properties if available
        if (_externalScopeIntegration != null)
        {
            Dictionary<string, object?> externalProperties = _externalScopeIntegration.GetExternalScopeProperties(logger);
            
            foreach (KeyValuePair<string, object?> property in externalProperties)
            {
                _ = scope.SetProperty(property.Key, property.Value);
            }
        }

        return scope;
    }

    public ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, string message)
        => Create(logger, logLevel, 0, message);

    public ILogMessageScope Create<TContext>(ILogger<TContext> logger, LogLevel logLevel, EventId eventId, string message)
        => new LogMessageScope(_ambientStack, logger, logLevel, eventId, message);
}
