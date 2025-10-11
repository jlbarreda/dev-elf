using AwesomeAssertions;

namespace DevElf.Tests;

[TestClass]
public class SerializableExceptionWrapperTests
{
    [TestMethod]
    public void Constructor_wraps_exception_properties_correctly()
    {
        // Arrange
        var ex = new InvalidOperationException("Test message")
        {
            HelpLink = "http://help",
            Source = "TestSource",
            HResult = 42
        };
        ex.Data["Key"] = "Value";

        try
        {
            throw ex;
        }
        catch (Exception caughtEx)
        {
            // Act
            var wrapper = new SerializableExceptionWrapper(caughtEx);

            // Assert
            _ = wrapper.Message.Should().Be(ex.Message);
            _ = wrapper.HelpLink.Should().Be(ex.HelpLink);
            _ = wrapper.HResult.Should().Be(ex.HResult);
            _ = wrapper.Source.Should().Be(ex.Source);
            _ = wrapper.StackTrace.Should().NotBeNull();
            _ = wrapper.Data["Key"].Should().Be("Value");
        }
    }

    [TestMethod]
    public void Constructor_wraps_inner_exception()
    {
        // Arrange
        var inner = new Exception("Inner");
        var ex = new Exception("Outer", inner);

        // Act
        var wrapper = new SerializableExceptionWrapper(ex);

        // Assert
        _ = wrapper.InnerException.Should().NotBeNull();
        _ = wrapper.InnerException!.Message.Should().Be("Inner");
    }

    [TestMethod]
    public void ToString_returns_json_serialized_string()
    {
        // Arrange
        var ex = new Exception("Test");
        var wrapper = new SerializableExceptionWrapper(ex);

        // Act
        string result = wrapper.ToString();

        // Assert
        _ = result.Should().Contain("Test");
        _ = result.Should().Contain("Message");
    }

    [TestMethod]
    public void Constructor_throws_on_null_exception()
    {
        // Arrange
        // Act
        var act = () => new SerializableExceptionWrapper(null!);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }
}
