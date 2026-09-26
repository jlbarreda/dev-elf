using DevElf.ArgumentValidation;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Provides a fluent API for building logging scopes with multiple properties.
/// </summary>
/// <remarks>
/// This class is typically created using the <see cref="LoggerExtensions.AddProperty"/> extension method
/// and allows chaining multiple property additions before beginning the scope.
/// </remarks>
public sealed class LoggingScopePropertiesBuilder
{
    private readonly ILogger logger;
    private readonly Dictionary<string, object?> properties = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="LoggingScopePropertiesBuilder"/> class.
    /// </summary>
    /// <param name="logger">The logger instance to create a scope for.</param>
    /// <param name="name">The name of the first property to add.</param>
    /// <param name="value">The value of the first property to add.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="logger"/> or <paramref name="name"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="name"/> is empty or contains only whitespace.
    /// </exception>
    internal LoggingScopePropertiesBuilder(ILogger logger, string name, object? value)
    {
        name.ThrowIfNullOrWhiteSpace();

        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        this.properties.Add(name, value);
    }

    /// <summary>
    /// Adds or updates a property in the logging scope.
    /// </summary>
    /// <param name="name">The name of the property to add or update.</param>
    /// <param name="value">The value of the property.</param>
    /// <returns>
    /// The current <see cref="LoggingScopePropertiesBuilder"/> instance for method chaining.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="name"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="name"/> is empty or contains only whitespace.
    /// </exception>
    /// <remarks>
    /// If a property with the same name already exists, its value will be replaced with the new value.
    /// </remarks>
    public LoggingScopePropertiesBuilder AddProperty(string name, object? value)
    {
        name.ThrowIfNullOrWhiteSpace();

        this.properties[name] = value;

        return this;
    }

    /// <summary>
    /// Begins a new logging scope with all the properties that have been added.
    /// </summary>
    /// <returns>
    /// An <see cref="IDisposable"/> that ends the scope when disposed, or <see langword="null"/>
    /// if the logger does not support scopes.
    /// </returns>
    /// <remarks>
    /// The returned <see cref="IDisposable"/> should be disposed to properly end the logging scope.
    /// It's recommended to use this within a <see langword="using"/> statement to ensure proper cleanup.
    /// </remarks>
    /// <example>
    /// <code>
    /// using (logger.AddProperty("UserId", userId)
    ///              .AddProperty("OperationId", operationId)
    ///              .BeginScope())
    /// {
    ///     logger.LogInformation("Operation started");
    ///     // All logs within this scope will include UserId and OperationId
    /// }
    /// </code>
    /// </example>
    public IDisposable? BeginScope() => this.logger.BeginScope(this.properties);
}
