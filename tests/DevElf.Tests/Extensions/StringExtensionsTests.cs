using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class StringExtensionsTests
{
    [TestMethod]
    public void IsNull_returns_true_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNull();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNull_returns_false_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNull();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNull_returns_false_when_string_has_value()
    {
        // Arrange
        string s = "test";

        // Act
        bool result = s.IsNull();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNull_returns_false_when_string_is_whitespace()
    {
        // Arrange
        string s = "   ";

        // Act
        bool result = s.IsNull();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNull_returns_false_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNotNull();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNull_returns_true_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNotNull();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNull_returns_true_when_string_has_value()
    {
        // Arrange
        string s = "test";

        // Act
        bool result = s.IsNotNull();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNull_returns_true_when_string_is_whitespace()
    {
        // Arrange
        string s = "   ";

        // Act
        bool result = s.IsNotNull();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_string_is_not_empty()
    {
        // Arrange
        string s = "abc";

        // Act
        bool result = s.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_string_is_whitespace()
    {
        // Arrange
        string s = "   ";

        // Act
        bool result = s.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_string_is_not_empty()
    {
        // Arrange
        string s = "abc";

        // Act
        bool result = s.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_string_is_whitespace()
    {
        // Arrange
        string s = "   ";

        // Act
        bool result = s.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_is_whitespace()
    {
        // Arrange
        string s = "   \t\n";

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_false_when_string_is_not_whitespace()
    {
        // Arrange
        string s = " a ";

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_false_when_string_is_null()
    {
        // Arrange
        string? s = null;

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_false_when_string_is_empty()
    {
        // Arrange
        string s = string.Empty;

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_false_when_string_is_whitespace()
    {
        // Arrange
        string s = "   \t\n";

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_true_when_string_is_not_whitespace()
    {
        // Arrange
        string s = " a ";

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_true_when_string_has_content()
    {
        // Arrange
        string s = "Hello World";

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrWhiteSpace_returns_true_when_string_has_single_character()
    {
        // Arrange
        string s = "a";

        // Act
        bool result = s.IsNotNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_contains_only_spaces()
    {
        // Arrange
        string s = "     ";

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_contains_only_tabs()
    {
        // Arrange
        string s = "\t\t\t";

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrWhiteSpace_returns_true_when_string_contains_only_newlines()
    {
        // Arrange
        string s = "\n\r\n";

        // Act
        bool result = s.IsNullOrWhiteSpace();

        // Assert
        _ = result.Should().BeTrue();
    }
}
