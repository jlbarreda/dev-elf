using AwesomeAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace DevElf.Logging.Tests;

[TestClass]
public class ServiceCollectionExtensionsTests
{
    [TestMethod]
    public void AddLogMessageScopes_registers_accessor_if_not_present()
    {
        // Arrange
        ServiceCollection services = new();

        // Act
        _ = services.AddLogMessageScopes();
        ServiceProvider provider = services.BuildServiceProvider();

        // Assert
        var accessor = provider.GetRequiredService<ILogMessageScopeAccessor>();
        _ = accessor.Should().NotBeNull();
    }

    [TestMethod]
    public void AddLogMessageScopes_is_idempotent()
    {
        // Arrange
        ServiceCollection services = new();

        // Act
        _ = services.AddLogMessageScopes();
        _ = services.AddLogMessageScopes();
        ServiceProvider provider = services.BuildServiceProvider();

        // Assert
        var accessor1 = provider.GetRequiredService<ILogMessageScopeAccessor>();
        var accessor2 = provider.GetRequiredService<ILogMessageScopeAccessor>();
        _ = accessor1.Should().BeSameAs(accessor2);
    }
}
