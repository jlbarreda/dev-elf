using AutoFixture;
using AwesomeAssertions;
using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class EnumerableExtensionsTests
{
    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_for_collection_with_elements()
    {
        // Arrange
        var fixture = new Fixture();
        IEnumerable<int> sut = fixture.CreateMany<int>(3);

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_for_list_with_elements()
    {
        // Arrange
        var fixture = new Fixture();
        List<string> sut = [.. fixture.CreateMany<string>(2)];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_for_array_with_elements()
    {
        // Arrange
        var fixture = new Fixture();
        int[] sut = [.. fixture.CreateMany<int>(5)];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_for_single_element_collection()
    {
        // Arrange
        var fixture = new Fixture();
        IEnumerable<string> sut = [fixture.Create<string>()];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_does_not_throw_for_enumerable_with_single_character()
    {
        // Arrange
        IEnumerable<char> sut = "a";

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentNullException_for_null_collection()
    {
        // Arrange
        IEnumerable<int>? sut = null;

        // Act
        Action act = () => sut!.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentNullException_for_null_list()
    {
        // Arrange
        List<string>? sut = null;

        // Act
        Action act = () => sut!.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentNullException_for_null_array()
    {
        // Arrange
        int[]? sut = null;

        // Act
        Action act = () => sut!.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(sut));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentException_for_empty_collection()
    {
        // Arrange
        IEnumerable<int> sut = [];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(sut))
            .WithMessage("The collection cannot be empty. (Parameter 'sut')");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentException_for_empty_list()
    {
        // Arrange
        List<string> sut = [];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(sut))
            .WithMessage("The collection cannot be empty. (Parameter 'sut')");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentException_for_empty_array()
    {
        // Arrange
        int[] sut = [];

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(sut))
            .WithMessage("The collection cannot be empty. (Parameter 'sut')");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_throws_ArgumentException_for_empty_enumerable()
    {
        // Arrange
        IEnumerable<char> sut = string.Empty;

        // Act
        Action act = () => sut.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(sut))
            .WithMessage("The collection cannot be empty. (Parameter 'sut')");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_uses_caller_argument_expression_for_parameter_name()
    {
        // Arrange
        List<int> myList = [];

        // Act
        Action act = () => myList.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(myList));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_uses_caller_argument_expression_for_null_parameter_name()
    {
        // Arrange
        IEnumerable<string>? nullCollection = null;

        // Act
        Action act = () => nullCollection!.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(nullCollection));
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_works_with_complex_expression()
    {
        // Arrange
        var data = new { Items = new List<int>() };

        // Act
        Action act = () => data.Items.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("data.Items");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_works_with_method_call_result()
    {
        // Arrange
        var fixture = new Fixture();
        var data = fixture.CreateMany<int>(5).ToList();

        // Act
        Action act = () => data.Where(x => x < 0).ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithParameterName("data.Where(x => x < 0)");
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_works_with_different_generic_types()
    {
        // Arrange
        var fixture = new Fixture();

        // Act & Assert - string collection
        IEnumerable<string> stringCollection = fixture.CreateMany<string>(3);
        Action stringAct = () => stringCollection.ThrowIfNullOrEmpty();
        _ = stringAct.Should().NotThrow();

        // Act & Assert - custom object collection
        IEnumerable<TestClass> objectCollection = fixture.CreateMany<TestClass>(2);
        Action objectAct = () => objectCollection.ThrowIfNullOrEmpty();
        _ = objectAct.Should().NotThrow();

        // Act & Assert - nullable int collection
        IEnumerable<int?> nullableIntCollection = [1, null, 3];
        Action nullableAct = () => nullableIntCollection.ThrowIfNullOrEmpty();
        _ = nullableAct.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_works_with_lazy_enumerable()
    {
        // Arrange
        var fixture = new Fixture();
        IEnumerable<int> lazyEnumerable = fixture.CreateMany<int>(3).Where(x => x > 0);

        // Act
        Action act = () => lazyEnumerable.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNullOrEmpty_works_with_empty_lazy_enumerable()
    {
        // Arrange
        var fixture = new Fixture();
        IEnumerable<int> emptyLazyEnumerable = fixture.CreateMany<int>(3).Where(x => x < 0);

        // Act
        Action act = () => emptyLazyEnumerable.ThrowIfNullOrEmpty();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithMessage("The collection cannot be empty. (Parameter 'emptyLazyEnumerable')");
    }

    #region Helper Types

    private class TestClass
    {
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }
    }

    #endregion
}
