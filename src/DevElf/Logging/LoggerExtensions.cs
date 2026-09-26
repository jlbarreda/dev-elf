using DevElf.ArgumentValidation;
using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

/// <summary>
/// Provides extension methods for <see cref="ILogger"/> to enhance logging capabilities.
/// </summary>
public static class LoggerExtensions
{
    /// <summary>
    /// Creates a new logging scope properties builder with the specified property.
    /// </summary>
    /// <param name="logger">The logger instance to create a scope for.</param>
    /// <param name="name">The name of the property to add to the logging scope.</param>
    /// <param name="value">The value of the property to add to the logging scope.</param>
    /// <returns>
    /// A <see cref="LoggingScopePropertiesBuilder"/> that can be used to add more properties
    /// or begin the logging scope.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="logger"/> or <paramref name="name"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="name"/> is empty or contains only whitespace.
    /// </exception>
    /// <remarks>
    /// This method provides a fluent API for building logging scopes with multiple properties.
    /// Use the returned builder to add additional properties via <see cref="LoggingScopePropertiesBuilder.AddProperty"/>
    /// and then call <see cref="LoggingScopePropertiesBuilder.BeginScope"/> to create the scope.
    /// </remarks>
    /// <example>
    /// <code>
    /// using (logger.AddProperty("UserId", userId)
    ///              .AddProperty("RequestId", requestId)
    ///              .BeginScope())
    /// {
    ///     logger.LogInformation("Processing request");
    /// }
    /// </code>
    /// </example>
    public static LoggingScopePropertiesBuilder AddProperty(
        this ILogger logger,
        string name,
        object? value)
    {
        logger.ThrowIfNull();
        name.ThrowIfNullOrWhiteSpace();

        return new(logger, name, value);
    }
}
