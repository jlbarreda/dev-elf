using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Extension methods for configuring log message scope services in dependency injection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds log message scope services to the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddLogMessageScopes(this IServiceCollection services)
    {
        services.AddSingleton<ILogMessageScopeStore<LogMessageScope>, AsyncLocalLogMessageScopeStore<LogMessageScope>>();
        services.AddSingleton<IExternalScopeIntegration, ExternalScopeIntegration>();
        services.AddSingleton<ILogMessageScopeFactory, LogMessageScopeFactory>();

        return services;
    }

    /// <summary>
    /// Adds log message scope services with custom configuration to the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configureOptions">An action to configure the log message scope options.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddLogMessageScopes(this IServiceCollection services, Action<LogMessageScopeOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(configureOptions);

        LogMessageScopeOptions options = new();
        configureOptions(options);

        if (options.UseAsyncLocalStorage)
        {
            services.AddSingleton<ILogMessageScopeStore<LogMessageScope>, AsyncLocalLogMessageScopeStore<LogMessageScope>>();
        }
        else
        {
            services.AddSingleton<ILogMessageScopeStore<LogMessageScope>, LogMessageScopeStore<LogMessageScope>>();
        }

        if (options.EnableExternalScopeIntegration)
        {
            services.AddSingleton<IExternalScopeIntegration, ExternalScopeIntegration>();
        }

        services.AddSingleton<ILogMessageScopeFactory>(serviceProvider =>
        {
            ILogMessageScopeStore<LogMessageScope> store = serviceProvider.GetRequiredService<ILogMessageScopeStore<LogMessageScope>>();
            IExternalScopeIntegration? externalIntegration = options.EnableExternalScopeIntegration
                ? serviceProvider.GetService<IExternalScopeIntegration>()
                : null;

            return new LogMessageScopeFactory(store, externalIntegration);
        });

        return services;
    }
}
