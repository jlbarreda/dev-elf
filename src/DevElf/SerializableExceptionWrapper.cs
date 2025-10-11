using System.Collections;
using System.Text.Json;
using DevElf.ArgumentValidation;

namespace DevElf;

/// <summary>
/// Wraps an <see cref="Exception"/> for serialization, including its properties and inner exception.
/// </summary>
public class SerializableExceptionWrapper
{
    private readonly string toString;

    /// <summary>
    /// Initializes a new instance of the <see cref="SerializableExceptionWrapper"/> class.
    /// </summary>
    /// <param name="exception">The exception to wrap.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown if <paramref name="exception"/> is <see langword="null"/>.
    /// </exception>
    public SerializableExceptionWrapper(Exception exception)
    {
        exception.ThrowIfNull();

        Data = exception.Data;
        HelpLink = exception.HelpLink;
        HResult = exception.HResult;
        InnerException = exception.InnerException is null ? null : new SerializableExceptionWrapper(exception.InnerException);
        Message = exception.Message;
        Source = exception.Source;
        StackTrace = exception.StackTrace;
        this.toString = exception.ToString();
    }

    /// <summary>
    /// Gets the data associated with the exception.
    /// </summary>
    public IDictionary Data { get; }

    /// <summary>
    /// Gets the help link for the exception.
    /// </summary>
    public string? HelpLink { get; }

    /// <summary>
    /// Gets the HRESULT value for the exception.
    /// </summary>
    public int HResult { get; }

    /// <summary>
    /// Gets the wrapped inner exception, if any.
    /// </summary>
    public SerializableExceptionWrapper? InnerException { get; }

    /// <summary>
    /// Gets the message describing the exception.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Gets the source of the exception.
    /// </summary>
    public string? Source { get; }

    /// <summary>
    /// Gets the stack trace for the exception.
    /// </summary>
    public string? StackTrace { get; }

    /// <summary>
    /// Returns a string representation of the wrapped exception, serialized as JSON if possible.
    /// </summary>
    /// <returns>
    /// A JSON string if serialization succeeds; otherwise, the original <see cref="Exception.ToString"/> value.
    /// </returns>
    public override string ToString()
    {
        try
        {
            return JsonSerializer.Serialize(this);
        }
        catch (Exception)
        {
            return this.toString;
        }
    }
}
