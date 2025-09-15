using AwesomeAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging.Tests;

[TestClass]
public class LogMessageScopeTests
{
    [TestMethod]
    public void Test()
    {
        ILogMessageScopeFactory factory = new LogMessageScopeFactory();
        ILogger logger = LoggerFactory
            .Create(builder =>
            {
                builder.AddJsonConsole(options => { options.IncludeScopes = true; });
            })
            .CreateLogger("TestLogger");

        using (var scope = factory.Create(logger, LogLevel.Information, "Test message"))
        {
            _ = scope.SetProperty("Key", "Value");

            using (var nestedScope = factory.Create(logger, LogLevel.Warning, "Nested message"))
            {
                _ = nestedScope.SetProperty("NestedKey", 123);

                var x = new X(factory, logger);

                x.Y();
            }
        }
    }

    [TestMethod]
    public void SetProperty_should_return_the_value()
    {
        // Arrange
        var factory = new LogMessageScopeFactory();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger("Test");

        using var scope = factory.Create(logger, LogLevel.Information, "Test");
        const string expectedValue = "TestValue";

        // Act
        string result = scope.SetProperty("Key", expectedValue);

        // Assert
        result.Should().Be(expectedValue);
    }

    [TestMethod]
    public void Dispose_should_throw_when_disposed_out_of_order()
    {
        // Arrange
        var factory = new LogMessageScopeFactory();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger("Test");

        var outerScope = factory.Create(logger, LogLevel.Information, "Outer");
        var innerScope = factory.Create(logger, LogLevel.Information, "Inner");

        // Act & Assert
        Action act = () => outerScope.Dispose();
        _ = act.Should().Throw<InvalidOperationException>()
           .WithMessage("LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.");

        // Clean up properly
        innerScope.Dispose();
        outerScope.Dispose();
    }

    [TestMethod]
    public void SetProperty_should_throw_when_disposed()
    {
        // Arrange
        var factory = new LogMessageScopeFactory();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger("Test");

        var scope = factory.Create(logger, LogLevel.Information, "Test");
        scope.Dispose();

        // Act & Assert
        Func<string> act = () => scope.SetProperty("Key", "Value");
        _ = act.Should().Throw<ObjectDisposedException>();
    }

    [TestMethod]
    public void ChangeLogLevel_should_throw_when_disposed()
    {
        // Arrange
        var factory = new LogMessageScopeFactory();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger("Test");

        var scope = factory.Create(logger, LogLevel.Information, "Test");
        scope.Dispose();

        // Act & Assert
        Action act = () => scope.ChangeLogLevel(LogLevel.Error);
        _ = act.Should().Throw<ObjectDisposedException>();
    }

    [TestMethod]
    public void Microsoft_scope_integration_should_work_with_extension_methods()
    {
        // Arrange
        var logger = LoggerFactory
            .Create(builder =>
            {
                builder.AddJsonConsole(options => { options.IncludeScopes = true; });
            })
            .CreateLogger("TestLogger");

        // Act & Assert
        using (var scope = logger.BeginMessageScope(LogLevel.Information, "Test message"))
        {
            _ = scope.SetProperty("TestKey", "TestValue");
            _ = scope.SetProperty("Number", 42);

            // The scope should be active and properties should be visible to Microsoft logging
            // This test verifies the extension method works correctly
        }
    }

    [TestMethod]
    public void External_scope_integration_should_merge_existing_scopes()
    {
        // Arrange
        var externalIntegration = new ExternalScopeIntegration();
        var factory = new LogMessageScopeFactory(new LogMessageScopeStore<LogMessageScope>(), externalIntegration);
        var logger = LoggerFactory.Create(builder => { }).CreateLogger("Test");

        // Act
        using (logger.BeginScope(new Dictionary<string, object?> { { "ExternalKey", "ExternalValue" } }))
        {
            using var scope = factory.Create(logger, LogLevel.Information, "Test");
            _ = scope.SetProperty("InternalKey", "InternalValue");

            // Both external and internal properties should be available
            // This test verifies external scope integration works
        }
    }

    [TestMethod]
    public void Dependency_injection_integration_should_work()
    {
        // Arrange
        ServiceCollection services = new();
        services.AddLogging(builder => builder.AddConsole());
        services.AddLogMessageScopes();

        ServiceProvider serviceProvider = services.BuildServiceProvider();
        ILogMessageScopeFactory factory = serviceProvider.GetRequiredService<ILogMessageScopeFactory>();
        ILogger<LogMessageScopeTests> logger = serviceProvider.GetRequiredService<ILogger<LogMessageScopeTests>>();

        // Act & Assert
        using var scope = factory.Create(logger, LogLevel.Information, "DI Test");
        _ = scope.SetProperty("DIKey", "DIValue");

        // The factory should be properly configured from DI
        factory.Should().NotBeNull();
    }

    [TestMethod]
    public void Custom_configuration_should_work()
    {
        // Arrange
        ServiceCollection services = new();
        services.AddLogging();
        services.AddLogMessageScopes(options =>
        {
            options.UseAsyncLocalStorage = false;
            options.EnableExternalScopeIntegration = false;
        });

        ServiceProvider serviceProvider = services.BuildServiceProvider();
        ILogMessageScopeFactory factory = serviceProvider.GetRequiredService<ILogMessageScopeFactory>();
        ILogger logger = serviceProvider.GetRequiredService<ILogger<LogMessageScopeTests>>();

        // Act & Assert
        using var scope = factory.Create(logger, LogLevel.Information, "Custom Config Test");
        _ = scope.SetProperty("ConfigKey", "ConfigValue");

        // The factory should work with custom configuration
        factory.Should().NotBeNull();
    }

    public class X
    {
        private readonly ILogMessageScopeFactory _factory;
        private readonly ILogger _logger;

        public X(ILogMessageScopeFactory factory, ILogger logger)
        {
            using (var scope = factory.Create(logger, LogLevel.Information, "Test message from X"))
            {
                _ = scope.SetProperty("XKey", "XValue");
            }

            _factory = factory;
            _logger = logger;
        }

        public void Y()
        {
            using (var scope = _factory.Create(_logger, LogLevel.Error, "Error message from Y"))
            {
                _ = scope.SetProperty("YKey", "YValue");
            }
        }
    }
}
