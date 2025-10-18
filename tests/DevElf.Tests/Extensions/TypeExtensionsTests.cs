using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class TypeExtensionsTests
{
    [TestMethod]
    public void GetTypeName_returns_type_name_when_useBuiltInTypeNameAliases_is_false()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        string result = type.GetTypeName(useBuiltInTypeNameAliases: false);

        // Assert
        _ = result.Should().Be("Int32");
    }

    [TestMethod]
    public void GetTypeName_returns_alias_when_useBuiltInTypeNameAliases_is_true()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        string result = type.GetTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("int");
    }

    [TestMethod]
    public void GetTypeName_returns_type_name_for_non_built_in_type()
    {
        // Arrange
        Type type = typeof(TypeExtensionsTests);

        // Act
        string result = type.GetTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("TypeExtensionsTests");
    }

    [TestMethod]
    public void GetTypeName_returns_bool_alias()
    {
        // Arrange
        Type type = typeof(bool);

        // Act
        string result = type.GetTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("bool");
    }

    [TestMethod]
    public void GetTypeName_returns_string_alias()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        string result = type.GetTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("string");
    }

    [TestMethod]
    public void GetTypeName_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetTypeName();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetFriendlyTypeName_returns_formatted_generic_type_name()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetFriendlyTypeName();

        // Assert
        _ = result.Should().Be("List<Int32>");
    }

    [TestMethod]
    public void GetFriendlyTypeName_returns_formatted_generic_type_name_with_aliases()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetFriendlyTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("List<int>");
    }

    [TestMethod]
    public void GetFriendlyTypeName_returns_formatted_nested_generic_type_name()
    {
        // Arrange
        Type type = typeof(Dictionary<string, List<int>>);

        // Act
        string result = type.GetFriendlyTypeName(useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("Dictionary<string, List<int>>");
    }

    [TestMethod]
    public void GetFriendlyTypeName_returns_simple_name_for_non_generic_type()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        string result = type.GetFriendlyTypeName();

        // Assert
        _ = result.Should().Be("Int32");
    }

    [TestMethod]
    public void GetFriendlyTypeName_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetFriendlyTypeName();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetCustomFormattedTypeName_returns_formatted_type_name_with_custom_format()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetCustomFormattedTypeName("[{0}[{1}]]", ";");

        // Assert
        _ = result.Should().Be("[List[Int32]]");
    }

    [TestMethod]
    public void GetCustomFormattedTypeName_returns_formatted_type_name_with_multiple_arguments()
    {
        // Arrange
        Type type = typeof(Dictionary<int, string>);

        // Act
        string result = type.GetCustomFormattedTypeName("{0}<{1}>", " | ", useBuiltInTypeNameAliases: true);

        // Assert
        _ = result.Should().Be("Dictionary<int | string>");
    }

    [TestMethod]
    public void GetCustomFormattedTypeName_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetCustomFormattedTypeName("{0}<{1}>");

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetCustomFormattedTypeName_throws_when_format_is_null()
    {
        // Arrange
        Type type = typeof(List<int>);
        string format = null!;

        // Act
        Action act = () => type.GetCustomFormattedTypeName(format);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetFriendlyTypeFullName_returns_full_name_for_generic_type()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetFriendlyTypeFullName();

        // Assert
        _ = result.Should().Be("System.Collections.Generic.List<System.Int32>");
    }

    [TestMethod]
    public void GetFriendlyTypeFullName_returns_full_name_for_nested_generic_type()
    {
        // Arrange
        Type type = typeof(Dictionary<string, List<int>>);

        // Act
        string result = type.GetFriendlyTypeFullName();

        // Assert
        _ = result.Should().Be("System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>>");
    }

    [TestMethod]
    public void GetFriendlyTypeFullName_returns_full_name_for_non_generic_type()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        string result = type.GetFriendlyTypeFullName();

        // Assert
        _ = result.Should().Be("System.Int32");
    }

    [TestMethod]
    public void GetFriendlyTypeFullName_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetFriendlyTypeFullName();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetCustomFormattedTypeFullName_returns_formatted_full_name_with_custom_format()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetCustomFormattedTypeFullName("{0}[{1}]", ";");

        // Assert
        _ = result.Should().Be("System.Collections.Generic.List[System.Int32]");
    }

    [TestMethod]
    public void GetCustomFormattedTypeFullName_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetCustomFormattedTypeFullName("{0}<{1}>");

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetCustomFormattedTypeFullName_throws_when_format_is_null()
    {
        // Arrange
        Type type = typeof(List<int>);
        string format = null!;

        // Act
        Action act = () => type.GetCustomFormattedTypeFullName(format);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetNameWithoutGenericParameters_returns_name_without_generic_marker()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        string result = type.GetNameWithoutGenericParameters();

        // Assert
        _ = result.Should().Be("List");
    }

    [TestMethod]
    public void GetNameWithoutGenericParameters_returns_name_for_non_generic_type()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        string result = type.GetNameWithoutGenericParameters();

        // Assert
        _ = result.Should().Be("Int32");
    }

    [TestMethod]
    public void GetNameWithoutGenericParameters_returns_name_for_multiple_generic_parameters()
    {
        // Arrange
        Type type = typeof(Dictionary<int, string>);

        // Act
        string result = type.GetNameWithoutGenericParameters();

        // Assert
        _ = result.Should().Be("Dictionary");
    }

    [TestMethod]
    public void GetNameWithoutGenericParameters_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.GetNameWithoutGenericParameters();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void IsStatic_returns_true_for_static_class()
    {
        // Arrange
        Type type = typeof(StaticTestClass);

        // Act
        bool result = type.IsStatic();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsStatic_returns_false_for_non_static_class()
    {
        // Arrange
        Type type = typeof(NonStaticTestClass);

        // Act
        bool result = type.IsStatic();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsStatic_returns_false_for_abstract_class()
    {
        // Arrange
        Type type = typeof(AbstractTestClass);

        // Act
        bool result = type.IsStatic();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsStatic_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.IsStatic();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_true_for_list()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        bool result = type.IsIEnumerableOfT();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_true_for_array()
    {
        // Arrange
        Type type = typeof(int[]);

        // Act
        bool result = type.IsIEnumerableOfT();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_true_for_string_when_not_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.IsIEnumerableOfT(excludeString: false);

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_false_for_string_when_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.IsIEnumerableOfT(excludeString: true);

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_false_for_int()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        bool result = type.IsIEnumerableOfT();

        // Assert
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void IsIEnumerableOfT_returns_true_for_IEnumerable_interface()
    {
        // Arrange
        Type type = typeof(IEnumerable<string>);

        // Act
        bool result = type.IsIEnumerableOfT();

        // Assert
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void IsIEnumerableOfT_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.IsIEnumerableOfT();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_true_and_gets_element_type_for_list()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType);

        // Assert
        _ = result.Should().BeTrue();
        _ = elementType.Should().Be<int>();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_true_and_gets_element_type_for_array()
    {
        // Arrange
        Type type = typeof(string[]);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType);

        // Assert
        _ = result.Should().BeTrue();
        _ = elementType.Should().Be<string>();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_true_for_string_when_not_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType, excludeString: false);

        // Assert
        _ = result.Should().BeTrue();
        _ = elementType.Should().Be<char>();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_false_for_string_when_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType, excludeString: true);

        // Assert
        _ = result.Should().BeFalse();
        _ = elementType.Should().BeNull();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_false_for_int()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType);

        // Assert
        _ = result.Should().BeFalse();
        _ = elementType.Should().BeNull();
    }

    [TestMethod]
    public void TryGetTypeOfTFromIEnumerableOfT_returns_true_for_IEnumerable_interface()
    {
        // Arrange
        Type type = typeof(IEnumerable<int>);

        // Act
        bool result = type.TryGetTypeOfTFromIEnumerableOfT(out Type? elementType);

        // Assert
        _ = result.Should().BeTrue();
        _ = elementType.Should().Be<int>();
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_returns_true_and_gets_interface_for_list()
    {
        // Arrange
        Type type = typeof(List<int>);

        // Act
        bool result = type.TryGetIEnumerableOfTType(out Type? interfaceType);

        // Assert
        _ = result.Should().BeTrue();
        _ = interfaceType.Should().NotBeNull();
        _ = interfaceType!.GetGenericTypeDefinition().Should().Be(typeof(IEnumerable<>));
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_returns_true_and_gets_interface_for_array()
    {
        // Arrange
        Type type = typeof(double[]);

        // Act
        bool result = type.TryGetIEnumerableOfTType(out Type? interfaceType);

        // Assert
        _ = result.Should().BeTrue();
        _ = interfaceType.Should().NotBeNull();
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_returns_true_for_string_when_not_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.TryGetIEnumerableOfTType(out Type? interfaceType, excludeString: false);

        // Assert
        _ = result.Should().BeTrue();
        _ = interfaceType.Should().NotBeNull();
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_returns_false_for_string_when_excluded()
    {
        // Arrange
        Type type = typeof(string);

        // Act
        bool result = type.TryGetIEnumerableOfTType(out Type? interfaceType, excludeString: true);

        // Assert
        _ = result.Should().BeFalse();
        _ = interfaceType.Should().BeNull();
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_returns_false_for_int()
    {
        // Arrange
        Type type = typeof(int);

        // Act
        bool result = type.TryGetIEnumerableOfTType(out Type? interfaceType);

        // Assert
        _ = result.Should().BeFalse();
        _ = interfaceType.Should().BeNull();
    }

    [TestMethod]
    public void TryGetIEnumerableOfTType_throws_when_type_is_null()
    {
        // Arrange
        Type type = null!;

        // Act
        Action act = () => type.TryGetIEnumerableOfTType(out _);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void GetTypeName_returns_all_built_in_type_aliases()
    {
        // Arrange & Act & Assert
        _ = typeof(bool).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("bool");
        _ = typeof(byte).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("byte");
        _ = typeof(sbyte).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("sbyte");
        _ = typeof(char).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("char");
        _ = typeof(decimal).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("decimal");
        _ = typeof(double).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("double");
        _ = typeof(float).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("float");
        _ = typeof(int).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("int");
        _ = typeof(uint).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("uint");
        _ = typeof(long).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("long");
        _ = typeof(ulong).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("ulong");
        _ = typeof(object).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("object");
        _ = typeof(short).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("short");
        _ = typeof(ushort).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("ushort");
        _ = typeof(string).GetTypeName(useBuiltInTypeNameAliases: true).Should().Be("string");
    }

    private static class StaticTestClass
    {
    }

    private class NonStaticTestClass
    {
    }

    private abstract class AbstractTestClass
    {
    }
}
