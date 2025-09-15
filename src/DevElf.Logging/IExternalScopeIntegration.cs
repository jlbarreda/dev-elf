using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Provides integration with Microsoft's external scope providers to merge existing scope properties.
/// </summary>
public interface IExternalScopeIntegration
{
    /// <summary>
    /// Gets all properties from external scopes (e.g., Microsoft's IExternalScopeProvider).
    /// </summary>
    /// <param name="logger">The logger to get external scopes from.</param>
    /// <returns>A dictionary containing all external scope properties.</returns>
    Dictionary<string, object?> GetExternalScopeProperties(ILogger logger);
}
