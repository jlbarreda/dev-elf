namespace DevElf.Logging;

/// <summary>
/// Provides access to the current <see cref="ILogMessageScope">log message scope</see>.
/// </summary>
public sealed class LogMessageScopeAccessor : ILogMessageScopeAccessor
{
    /// <inheritdoc />
    public ILogMessageScope? Current => AsyncLocalLogMessageScopeStack.Peek();
}
