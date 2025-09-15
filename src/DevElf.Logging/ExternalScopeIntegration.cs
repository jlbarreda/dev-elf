using System.Collections;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Default implementation that integrates with Microsoft's IExternalScopeProvider to read existing scopes.
/// </summary>
public class ExternalScopeIntegration : IExternalScopeIntegration
{
    /// <summary>
    /// Gets all properties from external scopes (e.g., Microsoft's IExternalScopeProvider).
    /// </summary>
    /// <param name="logger">The logger to get external scopes from.</param>
    /// <returns>A dictionary containing all external scope properties.</returns>
    public Dictionary<string, object?> GetExternalScopeProperties(ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(logger);

        Dictionary<string, object?> externalProperties = new(StringComparer.OrdinalIgnoreCase);

        // Try to get the IExternalScopeProvider from the logger
        if (logger is IExternalScopeProvider scopeProvider)
        {
            scopeProvider.ForEachScope(CollectScopeProperties, externalProperties);
        }

        return externalProperties;
    }

    /// <summary>
    /// Collects properties from a single scope into the provided dictionary.
    /// </summary>
    /// <param name="scope">The scope object.</param>
    /// <param name="state">The dictionary to collect properties into.</param>
    private static void CollectScopeProperties(object? scope, Dictionary<string, object?> state)
    {
        if (scope == null)
        {
            return;
        }

        // Handle different scope types
        switch (scope)
        {
            case IReadOnlyDictionary<string, object?> scopeDict:
                foreach (KeyValuePair<string, object?> kvp in scopeDict)
                {
                    state[kvp.Key] = kvp.Value;
                }

                break;

            case IEnumerable<KeyValuePair<string, object?>> scopeEnumerable:
                foreach (KeyValuePair<string, object?> kvp in scopeEnumerable)
                {
                    state[kvp.Key] = kvp.Value;
                }

                break;

            case IDictionary scopeDict when scopeDict.Count > 0:
                foreach (DictionaryEntry entry in scopeDict)
                {
                    if (entry.Key is string keyString)
                    {
                        state[keyString] = entry.Value;
                    }
                }

                break;

            case string scopeString:
                // For string scopes, use a generic key
                state["Scope"] = scopeString;
                break;

            default:
                // For other types, try to use ToString() or the object itself
                string key = scope.GetType().Name;
                state[key] = scope;
                break;
        }
    }
}