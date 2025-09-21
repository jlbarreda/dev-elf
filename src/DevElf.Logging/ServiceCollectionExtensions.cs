using DevElf.ArgumentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DevElf.Logging;

/// <summary>
/// Extension methods for configuring log message scope services in dependency injection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds the <see cref="ILogMessageScopeAccessor"/> service to the DI container, if not already registered.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    public static IServiceCollection AddLogMessageScopes(this IServiceCollection services)
    {
        services.ThrowIfNull();

        services.TryAddSingleton<ILogMessageScopeAccessor, LogMessageScopeAccessor>();

        return services;
    }
}
