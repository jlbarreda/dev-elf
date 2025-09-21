using AutoFixture;
using AwesomeAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;

namespace DevElf.Logging.Tests;

[TestClass]
public class LogMessageScopeTests
{
    [TestMethod]
    public void Constructor_throws_for_invalid_arguments()
    {
        // Arrange
        var fixture = new Fixture();
        ILogger logger = new FakeLogger();
        string anyMessage = fixture.Create<string>();

        // Act
        Action nullLogger = () => _ = new LogMessageScope(null!, LogLevel.Information, default, anyMessage);
        Action invalidLevel = () => _ = new LogMessageScope(logger, (LogLevel)999, default, anyMessage);
        Action nullMessage = () => _ = new LogMessageScope(logger, LogLevel.Information, default, null!);
        Action whitespaceMessage = () => _ = new LogMessageScope(logger, LogLevel.Information, default, "   ");

        // Assert
        _ = nullLogger.Should().Throw<ArgumentNullException>();
        _ = invalidLevel.Should().Throw<ArgumentOutOfRangeException>();
        _ = nullMessage.Should().Throw<ArgumentException>();
        _ = whitespaceMessage.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void SetException_does_not_add_property_when_flag_is_false()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        string message = fixture.Create<string>();
        var sut = logger.BeginMessageScope(LogLevel.Warning, message);
        var ex = fixture.Create<InvalidOperationException>();

        // Act
        sut.SetException(ex, setAsProperty: false);
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().HaveCount(1);
        _ = records[0].Exception.Should().BeSameAs(ex);
        var lastScopeState = records[0].Scopes[^1] as IReadOnlyDictionary<string, object?>;
        _ = lastScopeState.Should().NotBeNull();
        _ = lastScopeState.Should().NotContainKey("Exception");
    }

    [TestMethod]
    public void SetException_adds_property_when_flag_is_true()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        string message = fixture.Create<string>();
        var sut = logger.BeginMessageScope(LogLevel.Warning, message);
        var ex = fixture.Create<InvalidOperationException>();

        // Act
        sut.SetException(ex, setAsProperty: true);
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().HaveCount(1);
        _ = records[0].Exception.Should().BeSameAs(ex);
        var lastScopeState = records[0].Scopes[^1] as IReadOnlyDictionary<string, object?>;
        _ = lastScopeState.Should().NotBeNull();
        _ = lastScopeState.Should().ContainKey("Exception");
    }

    [TestMethod]
    public void SetProperty_is_case_insensitive_and_overrides()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        string message = fixture.Create<string>();
        var sut = logger.BeginMessageScope(LogLevel.Information, message);

        // Act
        _ = sut.SetProperty("KEY", 1);
        _ = sut.SetProperty("key", 2);
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().HaveCount(1);
        var scopes = records[0].Scopes[^1] as IReadOnlyDictionary<string, object?>;
        _ = scopes.Should().NotBeNull();
        _ = scopes.Should().ContainSingle();
        _ = scopes["key"].Should().Be(2);
        _ = scopes.Should().ContainKey("KEY");
        _ = scopes.Should().ContainKey("key");
    }

    [TestMethod]
    public void Out_of_order_dispose_logs_warning_then_messages()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        string outerMsg = fixture.Create<string>();
        string innerMsg = fixture.Create<string>();
        var outer = logger.BeginMessageScope(LogLevel.Information, outerMsg);
        var inner = logger.BeginMessageScope(LogLevel.Information, innerMsg);

        // Act
        outer.Dispose();
        inner.Dispose();
        outer.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records[0].Level.Should().Be(LogLevel.Warning);
        _ = records[0].Message.Should().Be("LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.");
        _ = records[1].Message.Should().Be(innerMsg);
        _ = records[2].Message.Should().Be(outerMsg);
    }
}
