using AutoFixture;
using AwesomeAssertions;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging.Tests;

[TestClass]
public class LogMessageScopeAccessorTests
{
    public TestContext TestContext { get; set; }

    [TestMethod]
    public void Current_returns_null_when_no_scope_active()
    {
        // Arrange
        var accessor = new LogMessageScopeAccessor();

        // Act
        var current = accessor.Current;

        // Assert
        _ = current.Should().BeNull();
    }

    [TestMethod]
    public void Current_tracks_current_scope_with_nesting_and_disposal()
    {
        // Arrange
        var fixture = new Fixture();
        ILogger logger = LoggerFactory.Create(b => { }).CreateLogger(fixture.Create<string>());
        var accessor = new LogMessageScopeAccessor();

        var outer = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        _ = accessor.Current.Should().BeSameAs(outer, "Outer scope should be current after creation.");

        var inner = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        _ = accessor.Current.Should().BeSameAs(inner, "Inner scope should be current after nesting.");

        // Act
        inner.Dispose();

        // Assert
        _ = accessor.Current.Should().BeSameAs(outer, "After disposing inner, outer should be current.");

        // Act
        outer.Dispose();

        // Assert
        _ = accessor.Current.Should().BeNull("After disposing outer, there should be no current scope.");
    }

    [TestMethod]
    public void Current_is_unchanged_on_out_of_order_dispose_and_recovers_after_correct_order()
    {
        // Arrange
        var fixture = new Fixture();
        ILogger logger = LoggerFactory.Create(b => { }).CreateLogger(fixture.Create<string>());
        var accessor = new LogMessageScopeAccessor();

        var outer = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        var inner = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());

        // Act: dispose out-of-order
        outer.Dispose();

        // Assert
        _ = accessor.Current.Should().BeSameAs(inner, "Out-of-order dispose should not change the current scope.");

        // Act in correct order now
        inner.Dispose();

        // Assert
        _ = accessor.Current.Should().BeSameAs(outer, "After disposing inner, outer should become current again.");

        // Act
        outer.Dispose();

        // Assert
        _ = accessor.Current.Should().BeNull("After disposing outer, there should be no current scope.");
    }

    [TestMethod]
    public async Task Current_flows_across_async_await()
    {
        // Arrange
        var fixture = new Fixture();
        ILogger logger = LoggerFactory.Create(b => { }).CreateLogger(fixture.Create<string>());
        var accessor = new LogMessageScopeAccessor();

        var scope = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        _ = accessor.Current.Should().BeSameAs(scope);

        // Act & Assert: across awaits in the same async flow
        await Task.Yield();
        _ = accessor.Current.Should().BeSameAs(scope);

        await Task.Delay(1, TestContext.CancellationToken);
        _ = accessor.Current.Should().BeSameAs(scope);

        // Act & Assert: inside a child task (ExecutionContext flows by default)
        await Task.Run(
            async () =>
            {
                _ = accessor.Current.Should().BeSameAs(scope);
                await Task.Yield();
                _ = accessor.Current.Should().BeSameAs(scope);
            },
            TestContext.CancellationToken);

        // Act
        scope.Dispose();

        // Assert
        _ = accessor.Current.Should().BeNull();
    }
}
