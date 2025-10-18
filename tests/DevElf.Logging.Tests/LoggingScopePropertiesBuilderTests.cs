using AwesomeAssertions;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace DevElf.Logging.Tests;

[TestClass]
public class LoggingScopePropertiesBuilderTests
{
    #region AddProperty Tests

    [TestMethod]
    public void AddProperty_adds_multiple_properties()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        _ = builder.AddProperty("Property2", 42)
            .AddProperty("Property3", true)
            .BeginScope();

        // Assert
        _ = capturedProperties.Should().HaveCount(3);
        _ = capturedProperties["Property1"].Should().Be("Value1");
        _ = capturedProperties["Property2"].Should().Be(42);
        _ = capturedProperties["Property3"].Should().Be(true);
    }

    [TestMethod]
    public void AddProperty_returns_same_builder_instance()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        LoggingScopePropertiesBuilder result = builder.AddProperty("Property2", "Value2");

        // Assert
        _ = result.Should().BeSameAs(builder);
    }

    [TestMethod]
    public void AddProperty_overwrites_existing_property_with_same_name()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "OriginalValue");

        // Act
        _ = builder.AddProperty("Property1", "UpdatedValue").BeginScope();

        // Assert
        _ = capturedProperties.Should().HaveCount(1);
        _ = capturedProperties["Property1"].Should().Be("UpdatedValue");
    }

    [TestMethod]
    public void AddProperty_accepts_null_values()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        _ = builder.AddProperty("Property2", null).BeginScope();

        // Assert
        _ = capturedProperties.Should().HaveCount(2);
        _ = capturedProperties["Property2"].Should().BeNull();
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentNullException_when_name_is_null()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        Action act = () => builder.AddProperty(null!, "Value");

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName("name");
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentException_when_name_is_empty()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        Action act = () => builder.AddProperty(string.Empty, "Value");

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("name");
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentException_when_name_is_whitespace()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        Action act = () => builder.AddProperty("   ", "Value");

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("name");
    }

    #endregion

    #region BeginScope Tests

    [TestMethod]
    public void BeginScope_calls_logger_with_all_properties()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1")
            .AddProperty("Property2", 42);

        // Act
        _ = builder.BeginScope();

        // Assert
        _ = logger.Received(1).BeginScope(Arg.Any<Dictionary<string, object?>>());
        _ = capturedProperties.Should().NotBeNull();
        _ = capturedProperties.Should().HaveCount(2);
    }

    [TestMethod]
    public void BeginScope_returns_disposable_from_logger()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        IDisposable expectedDisposable = Substitute.For<IDisposable>();
        _ = logger.BeginScope(Arg.Any<Dictionary<string, object?>>()).Returns(expectedDisposable);
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        IDisposable? result = builder.BeginScope();

        // Assert
        _ = result.Should().BeSameAs(expectedDisposable);
    }

    [TestMethod]
    public void BeginScope_returns_null_when_logger_returns_null()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        _ = logger.BeginScope(Arg.Any<Dictionary<string, object?>>()).Returns((IDisposable?)null);
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        IDisposable? result = builder.BeginScope();

        // Assert
        _ = result.Should().BeNull();
    }

    [TestMethod]
    public void BeginScope_can_be_called_multiple_times()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        LoggingScopePropertiesBuilder builder = logger.AddProperty("Property1", "Value1");

        // Act
        _ = builder.BeginScope();
        _ = builder.BeginScope();

        // Assert
        _ = logger.Received(2).BeginScope(Arg.Any<Dictionary<string, object?>>());
    }

    #endregion

    #region Constructor and Initial Property Tests

    [TestMethod]
    public void builder_includes_initial_property_from_constructor()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));

        // Act
        _ = logger.AddProperty("InitialProperty", "InitialValue").BeginScope();

        // Assert
        _ = capturedProperties.Should().HaveCount(1);
        _ = capturedProperties["InitialProperty"].Should().Be("InitialValue");
    }

    #endregion

    #region Property Order and Type Tests

    [TestMethod]
    public void builder_preserves_property_order()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));

        // Act
        _ = logger.AddProperty("First", 1)
            .AddProperty("Second", 2)
            .AddProperty("Third", 3)
            .BeginScope();

        // Assert
        string[] keys = capturedProperties.Keys.ToArray();
        _ = keys[0].Should().Be("First");
        _ = keys[1].Should().Be("Second");
        _ = keys[2].Should().Be("Third");
    }

    [TestMethod]
    public void builder_works_with_various_value_types()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        DateTime dateTime = DateTime.UtcNow;
        Guid guid = Guid.NewGuid();

        // Act
        _ = logger.AddProperty("String", "test")
            .AddProperty("Int", 42)
            .AddProperty("Double", 3.14)
            .AddProperty("Bool", true)
            .AddProperty("DateTime", dateTime)
            .AddProperty("Guid", guid)
            .AddProperty("Null", null)
            .BeginScope();

        // Assert
        _ = capturedProperties["String"].Should().Be("test");
        _ = capturedProperties["Int"].Should().Be(42);
        _ = capturedProperties["Double"].Should().Be(3.14);
        _ = capturedProperties["Bool"].Should().Be(true);
        _ = capturedProperties["DateTime"].Should().Be(dateTime);
        _ = capturedProperties["Guid"].Should().Be(guid);
        _ = capturedProperties["Null"].Should().BeNull();
    }

    #endregion
}
