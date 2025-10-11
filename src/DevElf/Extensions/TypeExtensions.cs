using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DevElf.ArgumentValidation;

namespace DevElf.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Type"/> to simplify type name formatting
/// and type analysis operations.
/// </summary>
public static class TypeExtensions
{
    private static readonly FrozenDictionary<Type, string> BuiltInTypeAliasMap = new Dictionary<Type, string>
    {
        [typeof(bool)] = "bool",
        [typeof(byte)] = "byte",
        [typeof(sbyte)] = "sbyte",
        [typeof(char)] = "char",
        [typeof(decimal)] = "decimal",
        [typeof(double)] = "double",
        [typeof(float)] = "float",
        [typeof(int)] = "int",
        [typeof(uint)] = "uint",
        [typeof(long)] = "long",
        [typeof(ulong)] = "ulong",
        [typeof(object)] = "object",
        [typeof(short)] = "short",
        [typeof(ushort)] = "ushort",
        [typeof(string)] = "string",
    }.ToFrozenDictionary();

#pragma warning disable CA1034 // Nested types should not be visible

    extension(Type)
    {
        /// <summary>
        /// Gets the dictionary mapping built-in types to their C# keyword aliases.
        /// </summary>
        public static IReadOnlyDictionary<Type, string> BuiltInTypeAliasMap => BuiltInTypeAliasMap;
    }

#pragma warning restore CA1034 // Nested types should not be visible

    /// <summary>
    /// Gets a friendly, readable name for the type using angle bracket notation for generic
    /// types.
    /// </summary>
    /// <param name="type">The type to format.</param>
    /// <param name="useBuiltInTypeNameAliases">
    /// <see langword="true"/> to use C# keyword aliases for built-in types;
    /// otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>
    /// A string representing the type name. For generic types, returns the format
    /// "TypeName&lt;T1, T2&gt;". For non-generic types, returns the simple type name.
    /// </returns>
    public static string GetFriendlyTypeName(this Type type, bool useBuiltInTypeNameAliases = false)
        => type.GetCustomFormattedTypeName("{0}<{1}>", ", ", useBuiltInTypeNameAliases);

    /// <summary>
    /// Gets a formatted name for the type using a custom format string.
    /// </summary>
    /// <param name="type">The type to format.</param>
    /// <param name="format">
    /// The format string where {0} is the base type name and {1} is the generic arguments.
    /// For non-generic types, only {0} is used.
    /// </param>
    /// <param name="argumentSeparator">
    /// The string used to separate generic type arguments. Default is ", ".
    /// </param>
    /// <param name="useBuiltInTypeNameAliases">
    /// <see langword="true"/> to use C# keyword aliases for built-in types;
    /// otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>
    /// A formatted string representation of the type name. For non-generic types, returns
    /// the simple type name.
    /// </returns>
    public static string GetCustomFormattedTypeName(
        this Type type,
        string format,
        string argumentSeparator = ", ",
        bool useBuiltInTypeNameAliases = false)
    {
        type.ThrowIfNull();
        format.ThrowIfNull();

        if (!type.IsGenericType)
        {
            return GetTypeName(type, useBuiltInTypeNameAliases);
        }

        string baseTypeName = GetTypeName(type, useBuiltInTypeNameAliases);

        if (baseTypeName.Contains('`', StringComparison.Ordinal))
        {
            baseTypeName = baseTypeName[..baseTypeName.IndexOf('`', StringComparison.Ordinal)];
        }

        Type[] genericArguments = type.GetGenericArguments();
        string argumentNames = string.Join(
            argumentSeparator,
            genericArguments.Select(arg => arg.GetCustomFormattedTypeName(format, argumentSeparator, useBuiltInTypeNameAliases)));

        return string.Format(CultureInfo.InvariantCulture, format, baseTypeName, argumentNames);
    }

    /// <summary>
    /// Gets the name of the type, optionally using C# keyword aliases for built-in types.
    /// </summary>
    /// <param name="type">The type to get the name from.</param>
    /// <param name="useBuiltInTypeNameAliases">
    /// <see langword="true"/> to use C# keyword aliases for built-in types;
    /// otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>The name of the type.</returns>
    public static string GetTypeName(this Type type, bool useBuiltInTypeNameAliases = false)
    {
        type.ThrowIfNull();

        return !useBuiltInTypeNameAliases
            ? type.Name
            : BuiltInTypeAliasMap.TryGetValue(type, out string? alias)
                ? alias
                : type.Name;
    }

    /// <summary>
    /// Gets a friendly, readable full name for the type using angle bracket notation for
    /// generic types.
    /// </summary>
    /// <param name="type">The type to format.</param>
    /// <returns>
    /// A string representing the type full name. For generic types, returns the format
    /// "Namespace.TypeName&lt;T1, T2&gt;". For non-generic types, returns the full type
    /// name.
    /// </returns>
    public static string GetFriendlyTypeFullName(this Type type)
        => type.GetCustomFormattedTypeFullName("{0}<{1}>");

    /// <summary>
    /// Gets a formatted full name for the type using a custom format string.
    /// </summary>
    /// <param name="type">The type to format.</param>
    /// <param name="format">
    /// The format string where {0} is the base type full name and {1} is the generic
    /// arguments. For non-generic types, only {0} is used.
    /// </param>
    /// <param name="argumentSeparator">
    /// The string used to separate generic type arguments. Default is ", ".
    /// </param>
    /// <returns>
    /// A formatted string representation of the type full name. For non-generic types,
    /// returns the full type name.
    /// </returns>
    public static string GetCustomFormattedTypeFullName(this Type type, string format, string argumentSeparator = ", ")
    {
        type.ThrowIfNull();
        format.ThrowIfNull();

        if (!type.IsGenericType)
        {
            return type.FullName ?? type.Name;
        }

        string baseTypeName = type.FullName?[..type.FullName.IndexOf('`', StringComparison.Ordinal)]
            ?? type.Name[..type.Name.IndexOf('`', StringComparison.Ordinal)];
        Type[] genericArguments = type.GetGenericArguments();
        string argumentNames = string.Join(argumentSeparator, genericArguments.Select(arg => arg.GetCustomFormattedTypeFullName(format, argumentSeparator)));

        return string.Format(CultureInfo.InvariantCulture, format, baseTypeName, argumentNames);
    }

    /// <summary>
    /// Gets the name of the type without generic parameter indicators.
    /// </summary>
    /// <param name="type">The type to get the name from.</param>
    /// <returns>
    /// The type name without the generic parameter count indicator (e.g., "List" instead
    /// of "List`1").
    /// </returns>
    public static string GetNameWithoutGenericParameters(this Type type)
    {
        type.ThrowIfNull();

        return !type.IsGenericType
            ? type.Name
            : type.Name[..type.Name.IndexOf('`', StringComparison.Ordinal)];
    }

    /// <summary>
    /// Determines whether the specified type is a static class.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>
    /// <see langword="true"/> if the type is a static class; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public static bool IsStatic(this Type type)
    {
        type.ThrowIfNull();

        return type.IsAbstract && type.IsSealed;
    }

    /// <summary>
    /// Determines whether the specified type implements
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="excludeString">
    /// <see langword="true"/> to exclude <see cref="string"/> from being considered as
    /// <see cref="IEnumerable{T}"/>; otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the type implements <see cref="IEnumerable{T}"/>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsIEnumerableOfT(
        this Type type,
        bool excludeString = false)
    {
        type.ThrowIfNull();

        if (excludeString && type == typeof(string))
        {
            return false;
        }

        // check if the type itself is IEnumerable<T>
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
        {
            return true;
        }

        // check if the type implements IEnumerable<T>
        return type.GetInterfaces().Any(interfaceType =>
            interfaceType.IsGenericType
            && interfaceType.GetGenericTypeDefinition() == typeof(IEnumerable<>));
    }

    /// <summary>
    /// Attempts to get the element type T from a type that implements
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="typeOfT">
    /// When this method returns, contains the element type T if the type implements
    /// <see cref="IEnumerable{T}"/>; otherwise, <see langword="null"/>.
    /// </param>
    /// <param name="excludeString">
    /// <see langword="true"/> to exclude <see cref="string"/> from being considered as
    /// <see cref="IEnumerable{T}"/>; otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the type implements <see cref="IEnumerable{T}"/> and
    /// the element type was retrieved; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryGetTypeOfTFromIEnumerableOfT(
        this Type type,
        [NotNullWhen(true)] out Type? typeOfT,
        bool excludeString = false)
    {
        type.ThrowIfNull();

        typeOfT = null;

        if (type.TryGetIEnumerableOfTType(out Type? enumerableInterfaceType, excludeString))
        {
            typeOfT = enumerableInterfaceType.GetGenericArguments().FirstOrDefault();
        }

        return typeOfT != null;
    }

    /// <summary>
    /// Attempts to get the <see cref="IEnumerable{T}"/> interface type from a type that
    /// implements it.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="enumerableInterfaceType">
    /// When this method returns, contains the <see cref="IEnumerable{T}"/> interface
    /// type if the type implements it; otherwise, <see langword="null"/>.
    /// </param>
    /// <param name="excludeString">
    /// <see langword="true"/> to exclude <see cref="string"/> from being considered as
    /// <see cref="IEnumerable{T}"/>; otherwise, <see langword="false"/>.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the type implements <see cref="IEnumerable{T}"/>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryGetIEnumerableOfTType(
        this Type type,
        [NotNullWhen(true)] out Type? enumerableInterfaceType,
        bool excludeString = false)
    {
        type.ThrowIfNull();

        enumerableInterfaceType = null;

        if (excludeString && type == typeof(string))
        {
            return false;
        }

        // check if the type itself is IEnumerable<T>
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
        {
            enumerableInterfaceType = type;

            return true;
        }

        // check if the type implements IEnumerable<T>
        enumerableInterfaceType = type.GetInterfaces()
            .FirstOrDefault(@interface =>
                @interface.IsGenericType
                && @interface.GetGenericTypeDefinition() == typeof(IEnumerable<>));

        return enumerableInterfaceType != null;
    }
}
