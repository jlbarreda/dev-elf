namespace DevElf.Logging;

/// <summary>
/// Configuration options for log message scopes.
/// </summary>
public class LogMessageScopeOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to use async-local storage for scopes.
    /// Default is <see langword="true"/>.
    /// </summary>
    public bool UseAsyncLocalStorage { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether to enable integration with external scope providers.
    /// Default is <see langword="true"/>.
    /// </summary>
    public bool EnableExternalScopeIntegration { get; set; } = true;
}
