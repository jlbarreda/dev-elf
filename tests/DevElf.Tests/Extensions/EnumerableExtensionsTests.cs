using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class EnumerableExtensionsTests
{
    [TestMethod]
    public void IsEmpty_throws_ArgumentNullException_when_source_is_null()
    {
        // Arrange
        IEnumerable<int>? source = null;

        // Act
        Action act = () => source!.IsEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void IsEmpty_returns_true_when_collection_is_empty()
    {
        // Arrange
        IEnumerable<int> source = [];

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsEmpty_returns_true_when_list_is_empty()
    {
        // Arrange
        List<string> source = new();

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsEmpty_returns_true_when_array_is_empty()
    {
        // Arrange
        int[] source = [];

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsEmpty_returns_false_when_collection_has_elements()
    {
        // Arrange
        IEnumerable<int> source = [1, 2, 3];

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsEmpty_returns_false_when_list_has_elements()
    {
        // Arrange
        List<string> source = new() { "a", "b" };

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsEmpty_returns_false_when_array_has_elements()
    {
        // Arrange
        int[] source = [42];

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsEmpty_returns_false_when_enumerable_has_single_element()
    {
        // Arrange
        IEnumerable<char> source = "a";

        // Act
        bool result = source.IsEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotEmpty_throws_ArgumentNullException_when_source_is_null()
    {
        // Arrange
        IEnumerable<int>? source = null;

        // Act
        Action act = () => source!.IsNotEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void IsNotEmpty_returns_false_when_collection_is_empty()
    {
        // Arrange
        IEnumerable<int> source = [];

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotEmpty_returns_false_when_list_is_empty()
    {
        // Arrange
        List<string> source = new();

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotEmpty_returns_false_when_array_is_empty()
    {
        // Arrange
        int[] source = [];

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotEmpty_returns_true_when_collection_has_elements()
    {
        // Arrange
        IEnumerable<int> source = [1, 2, 3];

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotEmpty_returns_true_when_list_has_elements()
    {
        // Arrange
        List<string> source = new() { "a", "b" };

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotEmpty_returns_true_when_array_has_elements()
    {
        // Arrange
        int[] source = [42];

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotEmpty_returns_true_when_enumerable_has_single_element()
    {
        // Arrange
        IEnumerable<char> source = "a";

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_source_is_null()
    {
        // Arrange
        IEnumerable<int>? source = null;

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_collection_is_empty()
    {
        // Arrange
        IEnumerable<int> source = [];

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_list_is_empty()
    {
        // Arrange
        List<string> source = new();

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_true_when_array_is_empty()
    {
        // Arrange
        int[] source = [];

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_collection_has_elements()
    {
        // Arrange
        IEnumerable<int> source = [1, 2, 3];

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_list_has_elements()
    {
        // Arrange
        List<string> source = new() { "a", "b" };

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_array_has_elements()
    {
        // Arrange
        int[] source = [42];

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNullOrEmpty_returns_false_when_enumerable_has_single_element()
    {
        // Arrange
        IEnumerable<char> source = "a";

        // Act
        bool result = source.IsNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_source_is_null()
    {
        // Arrange
        IEnumerable<int>? source = null;

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_collection_is_empty()
    {
        // Arrange
        IEnumerable<int> source = [];

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_list_is_empty()
    {
        // Arrange
        List<string> source = new();

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_array_is_empty()
    {
        // Arrange
        int[] source = [];

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_collection_has_elements()
    {
        // Arrange
        IEnumerable<int> source = [1, 2, 3];

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_list_has_elements()
    {
        // Arrange
        List<string> source = new() { "a", "b" };

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_array_has_elements()
    {
        // Arrange
        int[] source = [42];

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_true_when_enumerable_has_single_element()
    {
        // Arrange
        IEnumerable<char> source = "a";

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotEmpty_returns_false_when_enumerable_is_empty()
    {
        // Arrange
        IEnumerable<char> source = string.Empty;

        // Act
        bool result = source.IsNotEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_when_enumerable_is_empty()
    {
        // Arrange
        IEnumerable<char> source = string.Empty;

        // Act
        bool result = source.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotEmpty_works_with_lazy_enumerable()
    {
        // Arrange
        int[] baseArray = [1, 2, 3, 4, 5];
        IEnumerable<int> lazyEnumerable = baseArray.Where(x => x > 2);

        // Act
        bool result = lazyEnumerable.IsNotEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotEmpty_returns_false_with_empty_lazy_enumerable()
    {
        // Arrange
        int[] baseArray = [1, 2, 3];
        IEnumerable<int> emptyLazyEnumerable = baseArray.Where(x => x > 10);

        // Act
        bool result = emptyLazyEnumerable.IsNotEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_works_with_lazy_enumerable()
    {
        // Arrange
        int[] baseArray = [1, 2, 3, 4, 5];
        IEnumerable<int> lazyEnumerable = baseArray.Where(x => x > 2);

        // Act
        bool result = lazyEnumerable.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsNotNullOrEmpty_returns_false_with_empty_lazy_enumerable()
    {
        // Arrange
        int[] baseArray = [1, 2, 3];
        IEnumerable<int> emptyLazyEnumerable = baseArray.Where(x => x > 10);

        // Act
        bool result = emptyLazyEnumerable.IsNotNullOrEmpty();

        // Assert
        _ = result.Should().BeFalse();
    }
}
