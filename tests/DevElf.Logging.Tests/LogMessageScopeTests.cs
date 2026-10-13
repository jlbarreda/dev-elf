using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AwesomeAssertions;
using DevElf.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;
using NSubstitute;

namespace DevElf.Logging.Tests;

public class LogMessageScopeTests
{
    private const string OutOfOrderDisposeWarning = "LogMessageScope disposed out of order. Scopes must be disposed in LIFO order.";

    [Test]
    public void Constructor_throws_when_logger_is_null()
    {
        // Arrange
        var fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        ILogger logger = null!;
        fixture.Inject(logger);

        // Act
        var act = fixture.Create<LogMessageScope>;

        // Assert
        _ = act.UnwrapAndReThrow().Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(logger));
    }

    [Test]
    public void Constructor_throws_when_logLevel_is_invalid()
    {
        // Arrange
        var fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        var logLevel = (LogLevel)int.MaxValue;
        fixture.Inject(logLevel);

        // Act
        var act = fixture.Create<LogMessageScope>;

        // Assert
        _ = act.UnwrapAndReThrow().Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(logLevel));
    }

    [Test]
    public void Constructor_throws_when_message_is_null()
    {
        // Arrange
        var fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        string message = null!;
        fixture.Inject(message);

        // Act
        var act = fixture.Create<LogMessageScope>;

        // Assert
        _ = act.UnwrapAndReThrow().Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(message));
    }

    [Test]
    public void Constructor_throws_when_message_is_empty()
    {
        // Arrange
        var fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        string message = "";
        fixture.Inject(message);

        // Act
        var act = fixture.Create<LogMessageScope>;

        // Assert
        _ = act.UnwrapAndReThrow().Should().Throw<ArgumentException>()
            .WithParameterName(nameof(message));
    }

    [Test]
    public void Constructor_throws_when_message_is_white_space()
    {
        // Arrange
        var fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        string message = "    ";
        fixture.Inject(message);

        // Act
        var act = fixture.Create<LogMessageScope>;

        // Assert
        _ = act.UnwrapAndReThrow().Should().Throw<ArgumentException>()
            .WithParameterName(nameof(message));
    }

    [Test]
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

    [Test]
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

    [Test]
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
        _ = scopes.Should().ContainKey("Key");
    }

    [Test]
    public void SetProperty_emits_updated_object_as_named_scope_property()
    {
        // Arrange
        var fake = new FakeLogger();
        ILogger logger = fake;
        var sut = logger.BeginMessageScope(LogLevel.Information, "message");
        var sectionOne = new SectionOne("started", 1, []);
        _ = sut.SetProperty("SectionOne", sectionOne);

        sectionOne.SomeCollection.Add("item");
        sectionOne = sectionOne with { Count = 2 };
        _ = sut.SetProperty("SectionOne", sectionOne);

        // Act
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().ContainSingle();
        var properties = records[0].Scopes[^1] as IReadOnlyDictionary<string, object?>;
        _ = properties.Should().NotBeNull();
        _ = properties.Should().ContainSingle();
        _ = properties!["SectionOne"].Should().BeSameAs(sectionOne);

        var loggedSection = (SectionOne)properties["SectionOne"]!;
        _ = loggedSection.Count.Should().Be(2);
        _ = loggedSection.SomeCollection.Should().ContainSingle().Which.Should().Be("item");
    }

    [Test]
    public void Out_of_order_dispose_logs_warning_and_still_logs_message()
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
        _ = records.Should().HaveCount(3);
        _ = records[0].Level.Should().Be(LogLevel.Warning);
        _ = records[0].Message.Should().Be(OutOfOrderDisposeWarning);
        _ = records[1].Message.Should().Be(outerMsg);
        _ = records[2].Message.Should().Be(innerMsg);
    }

    [Test]
    public async Task Scope_created_in_async_method_logs_when_disposed_by_caller()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        string message = fixture.Create<string>();
        var eventId = new EventId(1001, "Import");

        async Task<ILogMessageScope> CreateScopeAsync()
        {
            await Task.Yield();

            return logger.BeginMessageScope(LogLevel.Information, eventId, message);
        }

        var sut = await CreateScopeAsync();

        // Act
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().HaveCount(2);
        _ = records[0].Level.Should().Be(LogLevel.Warning);
        _ = records[0].Message.Should().Be(OutOfOrderDisposeWarning);
        _ = records[1].Level.Should().Be(LogLevel.Information);
        _ = records[1].Id.Should().Be(eventId);
        _ = records[1].Message.Should().Be(message);
        _ = records[1].Exception.Should().BeNull();
    }

    [Test]
    public async Task Scope_disposed_in_child_flow_is_not_current_in_parent_flow()
    {
        // Arrange
        var fixture = new Fixture();
        ILogger logger = new FakeLogger();
        var accessor = new LogMessageScopeAccessor();
        var outer = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        var sut = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());

        // Act
        await Task.Run(sut.Dispose);

        // Assert
        _ = accessor.Current.Should().BeSameAs(outer);

        var next = logger.BeginMessageScope(LogLevel.Information, fixture.Create<string>());
        _ = accessor.Current.Should().BeSameAs(next);
        next.Dispose();
        _ = accessor.Current.Should().BeSameAs(outer);
        outer.Dispose();
        _ = accessor.Current.Should().BeNull();
    }

    [Test]
    public void SetException_adds_property_by_default()
    {
        // Arrange
        var fixture = new Fixture();
        var fake = new FakeLogger();
        ILogger logger = fake;
        var sut = logger.BeginMessageScope(LogLevel.Error, fixture.Create<string>());
        var ex = fixture.Create<InvalidOperationException>();

        // Act
        sut.SetException(ex);
        sut.Dispose();

        // Assert
        var records = fake.Collector.GetSnapshot();
        _ = records.Should().ContainSingle();
        _ = records[0].Exception.Should().BeSameAs(ex);
        var properties = records[0].Scopes[^1] as IReadOnlyDictionary<string, object?>;
        _ = properties.Should().NotBeNull();
        _ = properties!["Exception"].Should().BeSameAs(ex);
    }

    [Test]
    public void Dispose_does_not_begin_scope_when_log_level_is_disabled()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        _ = logger.IsEnabled(Arg.Any<LogLevel>()).Returns(false);
        var sut = logger.BeginMessageScope(LogLevel.Debug, "message");
        _ = sut.SetProperty("key", "value");

        // Act
        sut.Dispose();

        // Assert
        _ = logger.DidNotReceiveWithAnyArgs().BeginScope<IReadOnlyDictionary<string, object?>>(default!);
    }

    [Test]
    public void Dispose_marks_scope_disposed_when_logging_throws()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        _ = logger.IsEnabled(Arg.Any<LogLevel>()).Returns(true);
        _ = logger.BeginScope(Arg.Any<IReadOnlyDictionary<string, object?>>())
            .Returns(_ => throw new InvalidOperationException("BeginScope failed."));
        var accessor = new LogMessageScopeAccessor();
        var sut = logger.BeginMessageScope(LogLevel.Information, "message");

        // Act
        Action dispose = sut.Dispose;

        // Assert
        _ = dispose.Should().Throw<InvalidOperationException>()
            .WithMessage("BeginScope failed.");
        _ = accessor.Current.Should().BeNull();
        _ = dispose.Should().NotThrow();

        Action setProperty = () => sut.SetProperty("key", "value");
        _ = setProperty.Should().Throw<ObjectDisposedException>();
    }

    private sealed record SectionOne(string Event, int Count, List<string> SomeCollection);
}
