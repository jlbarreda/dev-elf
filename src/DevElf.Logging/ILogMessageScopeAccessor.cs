namespace DevElf.Logging;

/// <summary>
/// Provides access to the current <see cref="ILogMessageScope"/>.
/// </summary>
public interface ILogMessageScopeAccessor
{
    /// <summary>
    /// Gets the current <see cref="ILogMessageScope"/>, or
    /// <see langword="null"/> when no scope is active.
    /// </summary>
    ILogMessageScope? Current { get; }
}
