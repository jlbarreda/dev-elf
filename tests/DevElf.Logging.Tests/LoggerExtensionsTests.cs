using AwesomeAssertions;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace DevElf.Logging.Tests;

[TestClass]
public class LoggerExtensionsTests
{
    #region AddProperty Tests

    [TestMethod]
    public void AddProperty_creates_builder_with_single_property()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        string propertyName = "TestProperty";
        object propertyValue = "TestValue";

        // Act
        LoggingScopePropertiesBuilder builder = logger.AddProperty(propertyName, propertyValue);

        // Assert
        _ = builder.Should().NotBeNull();
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentNullException_when_logger_is_null()
    {
        // Arrange
        ILogger? logger = null;
        string propertyName = "TestProperty";
        object propertyValue = "TestValue";

        // Act
        Action act = () => logger!.AddProperty(propertyName, propertyValue);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName("logger");
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentNullException_when_name_is_null()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        string? propertyName = null;
        object propertyValue = "TestValue";

        // Act
        Action act = () => logger.AddProperty(propertyName!, propertyValue);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName("name");
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentException_when_name_is_empty()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        string propertyName = string.Empty;
        object propertyValue = "TestValue";

        // Act
        Action act = () => logger.AddProperty(propertyName, propertyValue);

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("name");
    }

    [TestMethod]
    public void AddProperty_throws_ArgumentException_when_name_is_whitespace()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        string propertyName = "   ";
        object propertyValue = "TestValue";

        // Act
        Action act = () => logger.AddProperty(propertyName, propertyValue);

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("name");
    }

    [TestMethod]
    public void AddProperty_accepts_null_value()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        string propertyName = "TestProperty";
        object? propertyValue = null;

        // Act
        LoggingScopePropertiesBuilder builder = logger.AddProperty(propertyName, propertyValue);

        // Assert
        _ = builder.Should().NotBeNull();
    }

    [TestMethod]
    public void AddProperty_allows_fluent_chaining()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));

        // Act
        _ = logger.AddProperty("Property1", "Value1")
            .AddProperty("Property2", 42)
            .AddProperty("Property3", true)
            .BeginScope();

        // Assert
        _ = capturedProperties.Should().NotBeNull();
        _ = capturedProperties.Should().HaveCount(3);
        _ = capturedProperties["Property1"].Should().Be("Value1");
        _ = capturedProperties["Property2"].Should().Be(42);
        _ = capturedProperties["Property3"].Should().Be(true);
    }

    [TestMethod]
    public void AddProperty_with_complex_object_value()
    {
        // Arrange
        ILogger logger = Substitute.For<ILogger>();
        Dictionary<string, object?> capturedProperties = null!;
        _ = logger.BeginScope(Arg.Do<Dictionary<string, object?>>(props => capturedProperties = props));
        var complexValue = new { Id = 123, Name = "Test" };

        // Act
        _ = logger.AddProperty("ComplexProperty", complexValue).BeginScope();

        // Assert
        _ = capturedProperties.Should().NotBeNull();
        _ = capturedProperties["ComplexProperty"].Should().BeSameAs(complexValue);
    }

    #endregion
}
