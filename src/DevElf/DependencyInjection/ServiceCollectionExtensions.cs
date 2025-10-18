using DevElf.ArgumentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DevElf.DependencyInjection;

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/> that simplify service registration
/// and factory function patterns in dependency injection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers a service with the specified lifetime and also registers a factory function
    /// (<see cref="Func{TService}"/>) that can be injected to create instances on demand.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <example>
    /// <code>
    /// services.AddWithFactoryFunc&lt;IMyService&gt;(ServiceLifetime.Scoped);
    /// 
    /// // Later, inject Func&lt;IMyService&gt; to create instances on demand:
    /// public class Consumer(Func&lt;IMyService&gt; serviceFactory)
    /// {
    ///     public void DoWork()
    ///     {
    ///         var service = serviceFactory();
    ///         // use service...
    ///     }
    /// }
    /// </code>
    /// </example>
    public static IServiceCollection AddWithFactoryFunc<TService>(
        this IServiceCollection services,
        ServiceLifetime serviceLifetime)
        where TService : class
    {
        services.ThrowIfNull();

        return services
            .Add<TService>(serviceLifetime)
            .AddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Registers a service using a factory function with the specified lifetime and also registers 
    /// a factory function (<see cref="Func{TService}"/>) that can be injected to create instances on demand.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <example>
    /// <code>
    /// services.AddWithFactoryFunc&lt;IMyService&gt;(
    ///     sp => new MyService(sp.GetRequiredService&lt;IDependency&gt;()),
    ///     ServiceLifetime.Transient);
    /// </code>
    /// </example>
    public static IServiceCollection AddWithFactoryFunc<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime serviceLifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        return services
            .Add(serviceFactory, serviceLifetime)
            .AddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Registers a service with its implementation type using the specified lifetime and also registers 
    /// a factory function (<see cref="Func{TService}"/>) that can be injected to create instances on demand.
    /// </summary>
    /// <typeparam name="TService">The service type to register. Must be a class.</typeparam>
    /// <typeparam name="TImplementation">
    /// The implementation type that implements <typeparamref name="TService"/>.
    /// </typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <example>
    /// <code>
    /// services.AddWithFactoryFunc&lt;IMyService, MyServiceImpl&gt;(ServiceLifetime.Singleton);
    /// </code>
    /// </example>
    public static IServiceCollection AddWithFactoryFunc<TService, TImplementation>(
        this IServiceCollection services,
        ServiceLifetime serviceLifetime)
        where TService : class
        where TImplementation : TService
    {
        services.ThrowIfNull();

        return services
            .Add<TService, TImplementation>(serviceLifetime)
            .AddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Tries to register a service with the specified lifetime (if not already registered) and also 
    /// registers a factory function (<see cref="Func{TService}"/>) that can be injected to create 
    /// instances on demand.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet. The factory function is also registered only if not already present.
    /// </remarks>
    public static IServiceCollection TryAddWithFactoryFunc<TService>(
        this IServiceCollection services,
        ServiceLifetime serviceLifetime)
        where TService : class
    {
        services.ThrowIfNull();

        return services
            .TryAdd<TService>(serviceLifetime)
            .TryAddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Tries to register a service using a factory function with the specified lifetime 
    /// (if not already registered) and also registers a factory function (<see cref="Func{TService}"/>) 
    /// that can be injected to create instances on demand.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet. The factory function is also registered only if not already present.
    /// </remarks>
    public static IServiceCollection TryAddWithFactoryFunc<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime serviceLifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        return services
            .TryAdd(serviceFactory, serviceLifetime)
            .TryAddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Tries to register a service with its implementation type using the specified lifetime 
    /// (if not already registered) and also registers a factory function (<see cref="Func{TService}"/>) 
    /// that can be injected to create instances on demand.
    /// </summary>
    /// <typeparam name="TService">The service type to register. Must be a class.</typeparam>
    /// <typeparam name="TImplementation">
    /// The implementation type that implements <typeparamref name="TService"/>.
    /// </typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
    /// <param name="serviceLifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet. The factory function is also registered only if not already present.
    /// </remarks>
    public static IServiceCollection TryAddWithFactoryFunc<TService, TImplementation>(
        this IServiceCollection services,
        ServiceLifetime serviceLifetime)
        where TService : class
        where TImplementation : TService
    {
        services.ThrowIfNull();

        return services
            .TryAdd<TService, TImplementation>(serviceLifetime)
            .TryAddFactoryFunc<TService>(ServiceLifetime.Singleton);
    }

    /// <summary>
    /// Registers a factory function (<see cref="Func{TService}"/>) with the specified lifetime 
    /// that resolves instances of <typeparamref name="TService"/> from the service provider.
    /// </summary>
    /// <typeparam name="TService">The type of service the factory will create. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the factory to.</param>
    /// <param name="factoryLifetime">The lifetime of the factory function itself.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// The factory function calls <see cref="Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService{T}(IServiceProvider)"/>
    /// to resolve the service when invoked. The service itself must be registered separately.
    /// </remarks>
    /// <example>
    /// <code>
    /// services.AddScoped&lt;IMyService, MyServiceImpl&gt;();
    /// services.AddFactoryFunc&lt;IMyService&gt;(ServiceLifetime.Singleton);
    /// 
    /// // Later, inject Func&lt;IMyService&gt; to create instances on demand
    /// </code>
    /// </example>
    public static IServiceCollection AddFactoryFunc<TService>(
        this IServiceCollection services,
        ServiceLifetime factoryLifetime)
        where TService : class
    {
        services.ThrowIfNull();

        return services.Add<Func<TService>>(
            serviceProvider => serviceProvider.GetRequiredService<TService>,
            factoryLifetime);
    }

    /// <summary>
    /// Registers a factory function (<see cref="Func{TService}"/>) with the specified lifetime 
    /// that wraps a custom service factory for creating instances of <typeparamref name="TService"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service the factory will create. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the factory to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="factoryLifetime">The lifetime of the factory function itself.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This overload wraps the provided <paramref name="serviceFactory"/> in a parameter-less function
    /// that can be injected as <see cref="Func{TService}"/>.
    /// </remarks>
    /// <example>
    /// <code>
    /// services.AddFactoryFunc&lt;IMyService&gt;(
    ///     sp => new MyService(sp.GetRequiredService&lt;IDependency&gt;()),
    ///     ServiceLifetime.Singleton);
    /// </code>
    /// </example>
    public static IServiceCollection AddFactoryFunc<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime factoryLifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        return services.Add<Func<TService>>(
            serviceProvider => () => serviceFactory(serviceProvider),
            factoryLifetime);
    }

    /// <summary>
    /// Tries to register a factory function (<see cref="Func{TService}"/>) with the specified lifetime 
    /// (if not already registered) that resolves instances of <typeparamref name="TService"/> from the service provider.
    /// </summary>
    /// <typeparam name="TService">The type of service the factory will create. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the factory to.</param>
    /// <param name="factoryLifetime">The lifetime of the factory function itself.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// This method only registers the factory if no factory of type <see cref="Func{TService}"/> 
    /// has been registered yet.
    /// </remarks>
    public static IServiceCollection TryAddFactoryFunc<TService>(
        this IServiceCollection services,
        ServiceLifetime factoryLifetime)
        where TService : class
    {
        services.ThrowIfNull();

        return services.TryAdd<Func<TService>>(
            serviceProvider => serviceProvider.GetRequiredService<TService>,
            factoryLifetime);
    }

    /// <summary>
    /// Tries to register a factory function (<see cref="Func{TService}"/>) with the specified lifetime 
    /// (if not already registered) that wraps a custom service factory for creating instances of <typeparamref name="TService"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service the factory will create. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the factory to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="factoryLifetime">The lifetime of the factory function itself.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method only registers the factory if no factory of type <see cref="Func{TService}"/> 
    /// has been registered yet.
    /// </remarks>
    public static IServiceCollection TryAddFactoryFunc<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime factoryLifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        return services.TryAdd<Func<TService>>(
            serviceProvider => () => serviceFactory(serviceProvider),
            factoryLifetime);
    }

    /// <summary>
    /// Registers a service of type <typeparamref name="TService"/> with itself as the implementation 
    /// type using the specified lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <example>
    /// <code>
    /// services.Add&lt;MyService&gt;(ServiceLifetime.Transient);
    /// </code>
    /// </example>
    public static IServiceCollection Add<TService>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
        where TService : class
    {
        services.ThrowIfNull();

        services.Add(new ServiceDescriptor(
            typeof(TService),
            typeof(TService),
            lifetime));

        return services;
    }

    /// <summary>
    /// Registers a service of type <typeparamref name="TService"/> using a factory function 
    /// with the specified lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <example>
    /// <code>
    /// services.Add&lt;IMyService&gt;(
    ///     sp => new MyService(sp.GetRequiredService&lt;IDependency&gt;()),
    ///     ServiceLifetime.Scoped);
    /// </code>
    /// </example>
    public static IServiceCollection Add<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime lifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        services.Add(new ServiceDescriptor(
            typeof(TService),
            serviceFactory,
            lifetime));

        return services;
    }

    /// <summary>
    /// Registers a service of type <typeparamref name="TService"/> with an implementation type 
    /// of <typeparamref name="TImplementation"/> using the specified lifetime.
    /// </summary>
    /// <typeparam name="TService">The service type to register. Must be a class.</typeparam>
    /// <typeparam name="TImplementation">
    /// The implementation type that implements <typeparamref name="TService"/>.
    /// </typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <example>
    /// <code>
    /// services.Add&lt;IMyService, MyServiceImpl&gt;(ServiceLifetime.Singleton);
    /// </code>
    /// </example>
    public static IServiceCollection Add<TService, TImplementation>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
        where TService : class
        where TImplementation : TService
    {
        services.ThrowIfNull();

        services.Add(new ServiceDescriptor(
            typeof(TService),
            typeof(TImplementation),
            lifetime));

        return services;
    }

    /// <summary>
    /// Tries to register a service of type <typeparamref name="TService"/> with itself as the implementation 
    /// type using the specified lifetime, if not already registered.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet.
    /// </remarks>
    public static IServiceCollection TryAdd<TService>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
        where TService : class
    {
        services.ThrowIfNull();

        services.TryAdd(new ServiceDescriptor(
            typeof(TService),
            typeof(TService),
            lifetime));

        return services;
    }

    /// <summary>
    /// Tries to register a service of type <typeparamref name="TService"/> using a factory function 
    /// with the specified lifetime, if not already registered.
    /// </summary>
    /// <typeparam name="TService">The type of service to register. Must be a class.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="serviceFactory">The factory function that creates instances of the service.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="services"/> or <paramref name="serviceFactory"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet.
    /// </remarks>
    public static IServiceCollection TryAdd<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> serviceFactory,
        ServiceLifetime lifetime)
        where TService : class
    {
        services.ThrowIfNull();
        serviceFactory.ThrowIfNull();

        services.TryAdd(new ServiceDescriptor(
            typeof(TService),
            serviceFactory,
            lifetime));

        return services;
    }

    /// <summary>
    /// Tries to register a service of type <typeparamref name="TService"/> with an implementation type 
    /// of <typeparamref name="TImplementation"/> using the specified lifetime, if not already registered.
    /// </summary>
    /// <typeparam name="TService">The service type to register. Must be a class.</typeparam>
    /// <typeparam name="TImplementation">
    /// The implementation type that implements <typeparamref name="TService"/>.
    /// </typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="services"/> is <see langword="null"/>.</exception>
    /// <remarks>
    /// This method only registers the service if no service of type <typeparamref name="TService"/> 
    /// has been registered yet.
    /// </remarks>
    public static IServiceCollection TryAdd<TService, TImplementation>(
        this IServiceCollection services,
        ServiceLifetime lifetime)
        where TService : class
        where TImplementation : TService
    {
        services.ThrowIfNull();

        services.TryAdd(new ServiceDescriptor(
            typeof(TService),
            typeof(TImplementation),
            lifetime));

        return services;
    }
}
