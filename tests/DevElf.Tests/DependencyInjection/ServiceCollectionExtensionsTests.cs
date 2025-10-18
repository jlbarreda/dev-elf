using AutoFixture;
using AwesomeAssertions;
using DevElf.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace DevElf.Tests.DependencyInjection;

[TestClass]
public class ServiceCollectionExtensionsTests
{
    #region AddWithFactoryFunc<TService> Tests

    [TestMethod]
    public void AddWithFactoryFunc_registers_service_and_factory_function()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.AddWithFactoryFunc<TestService>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetService<TestService>();
        var factory = provider.GetService<Func<TestService>>();

        _ = service.Should().NotBeNull();
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void AddWithFactoryFunc_factory_function_creates_service_instances()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddWithFactoryFunc<TestService>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance1 = factory();
        var instance2 = factory();

        // Assert
        _ = instance1.Should().NotBeNull();
        _ = instance2.Should().NotBeNull();
        _ = instance1.Should().NotBeSameAs(instance2);
    }

    [TestMethod]
    public void AddWithFactoryFunc_respects_service_lifetime()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddWithFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Act
        var service1 = provider.GetRequiredService<TestService>();
        var service2 = provider.GetRequiredService<TestService>();

        // Assert
        _ = service1.Should().BeSameAs(service2);
    }

    [TestMethod]
    public void AddWithFactoryFunc_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.AddWithFactoryFunc<TestService>(
            services!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region AddWithFactoryFunc<TService> with Factory Tests

    [TestMethod]
    public void AddWithFactoryFunc_with_factory_registers_service_and_factory_function()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.AddWithFactoryFunc<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<TestService>();
        var factory = provider.GetRequiredService<Func<TestService>>();

        _ = service.Should().NotBeNull();
        _ = service.Value.Should().Be(testValue);
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void AddWithFactoryFunc_with_factory_creates_instances_using_provided_factory()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();
        _ = services.AddWithFactoryFunc<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance = factory();

        // Assert
        _ = instance.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void AddWithFactoryFunc_with_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.AddWithFactoryFunc<TestService>(
            services!,
            sp => new TestService(),
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void AddWithFactoryFunc_with_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.AddWithFactoryFunc(
            serviceFactory!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region AddWithFactoryFunc<TService, TImplementation> Tests

    [TestMethod]
    public void AddWithFactoryFunc_with_implementation_registers_service_and_factory_function()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.AddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetService<ITestService>();
        var factory = provider.GetService<Func<ITestService>>();

        _ = service.Should().NotBeNull();
        _ = service.Should().BeOfType<TestServiceImpl>();
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void AddWithFactoryFunc_with_implementation_factory_creates_correct_implementation()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<Func<ITestService>>();
        var instance = factory();

        // Assert
        _ = instance.Should().BeOfType<TestServiceImpl>();
    }

    [TestMethod]
    public void AddWithFactoryFunc_with_implementation_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.AddWithFactoryFunc<ITestService, TestServiceImpl>(
            services!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region TryAddWithFactoryFunc<TService> Tests

    [TestMethod]
    public void TryAddWithFactoryFunc_registers_service_when_not_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAddWithFactoryFunc<TestService>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetService<TestService>();
        var factory = provider.GetService<Func<TestService>>();

        _ = service.Should().NotBeNull();
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_does_not_replace_existing_registration()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton(new TestService { Value = firstValue });

        // Act
        _ = services.TryAddWithFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<TestService>();

        // Assert
        _ = service.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.TryAddWithFactoryFunc<TestService>(
            services!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region TryAddWithFactoryFunc<TService> with Factory Tests

    [TestMethod]
    public void TryAddWithFactoryFunc_with_factory_registers_service_when_not_already_registered()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAddWithFactoryFunc<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<TestService>();
        _ = service.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_with_factory_does_not_replace_existing_registration()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        string secondValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton(new TestService { Value = firstValue });

        // Act
        _ = services.TryAddWithFactoryFunc<TestService>(
            sp => new TestService { Value = secondValue },
            ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<TestService>();

        // Assert
        _ = service.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_with_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.TryAddWithFactoryFunc<TestService>(
            services!,
            sp => new TestService(),
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_with_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.TryAddWithFactoryFunc(
            serviceFactory!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region TryAddWithFactoryFunc<TService, TImplementation> Tests

    [TestMethod]
    public void TryAddWithFactoryFunc_with_implementation_registers_service_when_not_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<ITestService>();
        _ = service.Should().BeOfType<TestServiceImpl>();
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_with_implementation_does_not_replace_existing_registration()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddSingleton<ITestService, AlternateTestServiceImpl>();

        // Act
        _ = services.TryAddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<ITestService>();

        // Assert
        _ = service.Should().BeOfType<AlternateTestServiceImpl>();
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_with_implementation_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => ServiceCollectionExtensions.TryAddWithFactoryFunc<ITestService, TestServiceImpl>(
            services!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region AddFactoryFunc<TService> Tests

    [TestMethod]
    public void AddFactoryFunc_registers_factory_function()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddTransient<TestService>();

        // Act
        _ = services.AddFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Assert
        var factory = provider.GetService<Func<TestService>>();
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void AddFactoryFunc_factory_creates_instances_from_service_provider()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddTransient<TestService>();
        _ = services.AddFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance1 = factory();
        var instance2 = factory();

        // Assert
        _ = instance1.Should().NotBeNull();
        _ = instance2.Should().NotBeNull();
        _ = instance1.Should().NotBeSameAs(instance2);
    }

    [TestMethod]
    public void AddFactoryFunc_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.AddFactoryFunc<TestService>(ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region AddFactoryFunc<TService> with Custom Factory Tests

    [TestMethod]
    public void AddFactoryFunc_with_custom_factory_registers_factory_function()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.AddFactoryFunc<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Assert
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance = factory();
        _ = instance.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void AddFactoryFunc_with_custom_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.AddFactoryFunc<TestService>(
            sp => new TestService(),
            ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void AddFactoryFunc_with_custom_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.AddFactoryFunc(
            serviceFactory!,
            ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region TryAddFactoryFunc<TService> Tests

    [TestMethod]
    public void TryAddFactoryFunc_registers_factory_when_not_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddTransient<TestService>();

        // Act
        _ = services.TryAddFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Assert
        var factory = provider.GetService<Func<TestService>>();
        _ = factory.Should().NotBeNull();
    }

    [TestMethod]
    public void TryAddFactoryFunc_does_not_replace_existing_factory_registration()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton<Func<TestService>>(() => new TestService { Value = firstValue });

        // Act
        _ = services.TryAddFactoryFunc<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance = factory();

        // Assert
        _ = instance.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAddFactoryFunc_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.TryAddFactoryFunc<TestService>(ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region TryAddFactoryFunc<TService> with Custom Factory Tests

    [TestMethod]
    public void TryAddFactoryFunc_with_custom_factory_registers_factory_when_not_already_registered()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAddFactoryFunc<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Assert
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance = factory();
        _ = instance.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void TryAddFactoryFunc_with_custom_factory_does_not_replace_existing_factory_registration()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        string secondValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton<Func<TestService>>(() => new TestService { Value = firstValue });

        // Act
        _ = services.TryAddFactoryFunc<TestService>(
            sp => new TestService { Value = secondValue },
            ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var factory = provider.GetRequiredService<Func<TestService>>();
        var instance = factory();

        // Assert
        _ = instance.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAddFactoryFunc_with_custom_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.TryAddFactoryFunc<TestService>(
            sp => new TestService(),
            ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void TryAddFactoryFunc_with_custom_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.TryAddFactoryFunc(
            serviceFactory!,
            ServiceLifetime.Singleton);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region Add<TService> Tests

    [TestMethod]
    public void Add_registers_service_with_specified_lifetime()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.Add<TestService>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service1 = provider.GetRequiredService<TestService>();
        var service2 = provider.GetRequiredService<TestService>();

        _ = service1.Should().NotBeNull();
        _ = service2.Should().NotBeNull();
        _ = service1.Should().NotBeSameAs(service2);
    }

    [TestMethod]
    public void Add_allows_multiple_registrations_of_same_service()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.Add<TestService>(ServiceLifetime.Transient);
        _ = services.Add<TestService>(ServiceLifetime.Transient);

        // Assert
        _ = services.Count.Should().Be(2);
    }

    [TestMethod]
    public void Add_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.Add<TestService>(ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region Add<TService> with Factory Tests

    [TestMethod]
    public void Add_with_factory_registers_service_using_factory()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.Add<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<TestService>();
        _ = service.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void Add_with_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.Add<TestService>(
            sp => new TestService(),
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void Add_with_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.Add(
            serviceFactory!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region Add<TService, TImplementation> Tests

    [TestMethod]
    public void Add_with_implementation_registers_service_with_implementation_type()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.Add<ITestService, TestServiceImpl>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<ITestService>();
        _ = service.Should().BeOfType<TestServiceImpl>();
    }

    [TestMethod]
    public void Add_with_implementation_respects_service_lifetime()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.Add<ITestService, TestServiceImpl>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();

        // Assert
        var service1 = provider.GetRequiredService<ITestService>();
        var service2 = provider.GetRequiredService<ITestService>();
        _ = service1.Should().BeSameAs(service2);
    }

    [TestMethod]
    public void Add_with_implementation_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.Add<ITestService, TestServiceImpl>(ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region TryAdd<TService> Tests

    [TestMethod]
    public void TryAdd_registers_service_when_not_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAdd<TestService>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<TestService>();
        _ = service.Should().NotBeNull();
    }

    [TestMethod]
    public void TryAdd_does_not_register_service_when_already_registered()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton(new TestService { Value = firstValue });

        // Act
        _ = services.TryAdd<TestService>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<TestService>();

        // Assert
        _ = service.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAdd_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.TryAdd<TestService>(ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region TryAdd<TService> with Factory Tests

    [TestMethod]
    public void TryAdd_with_factory_registers_service_when_not_already_registered()
    {
        // Arrange
        var fixture = new Fixture();
        string testValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAdd<TestService>(
            sp => new TestService { Value = testValue },
            ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<TestService>();
        _ = service.Value.Should().Be(testValue);
    }

    [TestMethod]
    public void TryAdd_with_factory_does_not_register_service_when_already_registered()
    {
        // Arrange
        var fixture = new Fixture();
        string firstValue = fixture.Create<string>();
        string secondValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton(new TestService { Value = firstValue });

        // Act
        _ = services.TryAdd<TestService>(
            sp => new TestService { Value = secondValue },
            ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<TestService>();

        // Assert
        _ = service.Value.Should().Be(firstValue);
    }

    [TestMethod]
    public void TryAdd_with_factory_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.TryAdd<TestService>(
            sp => new TestService(),
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    [TestMethod]
    public void TryAdd_with_factory_throws_ArgumentNullException_when_factory_is_null()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        Func<IServiceProvider, TestService>? serviceFactory = null;

        // Act
        Action act = () => services.TryAdd(
            serviceFactory!,
            ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(serviceFactory));
    }

    #endregion

    #region TryAdd<TService, TImplementation> Tests

    [TestMethod]
    public void TryAdd_with_implementation_registers_service_when_not_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services.TryAdd<ITestService, TestServiceImpl>(ServiceLifetime.Transient);
        var provider = services.BuildServiceProvider();

        // Assert
        var service = provider.GetRequiredService<ITestService>();
        _ = service.Should().BeOfType<TestServiceImpl>();
    }

    [TestMethod]
    public void TryAdd_with_implementation_does_not_register_service_when_already_registered()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddSingleton<ITestService, AlternateTestServiceImpl>();

        // Act
        _ = services.TryAdd<ITestService, TestServiceImpl>(ServiceLifetime.Singleton);
        var provider = services.BuildServiceProvider();
        var service = provider.GetRequiredService<ITestService>();

        // Assert
        _ = service.Should().BeOfType<AlternateTestServiceImpl>();
    }

    [TestMethod]
    public void TryAdd_with_implementation_throws_ArgumentNullException_when_services_is_null()
    {
        // Arrange
        IServiceCollection? services = null;

        // Act
        Action act = () => services!.TryAdd<ITestService, TestServiceImpl>(ServiceLifetime.Transient);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(services));
    }

    #endregion

    #region Method Chaining Tests

    [TestMethod]
    public void AddWithFactoryFunc_returns_service_collection_for_chaining()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        IServiceCollection result = services
            .AddWithFactoryFunc<TestService>(ServiceLifetime.Transient)
            .AddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);

        // Assert
        _ = result.Should().BeSameAs(services);
        _ = services.Count.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void TryAddWithFactoryFunc_returns_service_collection_for_chaining()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        IServiceCollection result = services
            .TryAddWithFactoryFunc<TestService>(ServiceLifetime.Transient)
            .TryAddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);

        // Assert
        _ = result.Should().BeSameAs(services);
    }

    [TestMethod]
    public void Add_methods_return_service_collection_for_chaining()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        IServiceCollection result = services
            .Add<TestService>(ServiceLifetime.Transient)
            .Add<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);

        // Assert
        _ = result.Should().BeSameAs(services);
    }

    [TestMethod]
    public void TryAdd_methods_return_service_collection_for_chaining()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        IServiceCollection result = services
            .TryAdd<TestService>(ServiceLifetime.Transient)
            .TryAdd<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);

        // Assert
        _ = result.Should().BeSameAs(services);
    }

    #endregion

    #region Complex Scenarios

    [TestMethod]
    public void AddWithFactoryFunc_allows_injecting_dependencies_into_created_instances()
    {
        // Arrange
        var fixture = new Fixture();
        string dependencyValue = fixture.Create<string>();
        IServiceCollection services = new ServiceCollection();

        _ = services.AddSingleton(new TestDependency { Value = dependencyValue });
        _ = services.AddWithFactoryFunc<TestServiceWithDependency>(ServiceLifetime.Transient);

        var provider = services.BuildServiceProvider();

        // Act
        var service = provider.GetRequiredService<TestServiceWithDependency>();

        // Assert
        _ = service.Dependency.Should().NotBeNull();
        _ = service.Dependency.Value.Should().Be(dependencyValue);
    }

    [TestMethod]
    public void Factory_function_uses_scoped_lifetime_appropriately()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        _ = services.AddWithFactoryFunc<TestService>(ServiceLifetime.Scoped);
        var provider = services.BuildServiceProvider();

        // Act
        using IServiceScope scope1 = provider.CreateScope();
        using IServiceScope scope2 = provider.CreateScope();

        var service1a = scope1.ServiceProvider.GetRequiredService<TestService>();
        var service1b = scope1.ServiceProvider.GetRequiredService<TestService>();
        var service2a = scope2.ServiceProvider.GetRequiredService<TestService>();

        // Assert
        _ = service1a.Should().BeSameAs(service1b);
        _ = service1a.Should().NotBeSameAs(service2a);
    }

    [TestMethod]
    public void Multiple_services_can_be_registered_with_different_lifetimes()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        _ = services
            .AddWithFactoryFunc<TestService>(ServiceLifetime.Singleton)
            .AddWithFactoryFunc<ITestService, TestServiceImpl>(ServiceLifetime.Scoped);

        var provider = services.BuildServiceProvider();

        // Assert
        var singleton1 = provider.GetRequiredService<TestService>();
        var singleton2 = provider.GetRequiredService<TestService>();

        using IServiceScope scope1 = provider.CreateScope();
        using IServiceScope scope2 = provider.CreateScope();

        var scoped1 = scope1.ServiceProvider.GetRequiredService<ITestService>();
        var scoped2 = scope2.ServiceProvider.GetRequiredService<ITestService>();

        _ = singleton1.Should().BeSameAs(singleton2);
        _ = scoped1.Should().NotBeSameAs(scoped2);
    }

    #endregion

    #region Helper Types

    private class TestService
    {
        public string Value { get; set; } = string.Empty;
    }

    private interface ITestService
    {
    }

    private class TestServiceImpl : ITestService
    {
    }

    private class AlternateTestServiceImpl : ITestService
    {
    }

    private class TestDependency
    {
        public string Value { get; set; } = string.Empty;
    }

    private class TestServiceWithDependency(TestDependency dependency)
    {
        public TestDependency Dependency { get; } = dependency;
    }

    #endregion
}
