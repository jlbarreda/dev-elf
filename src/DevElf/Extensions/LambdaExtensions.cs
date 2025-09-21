using System.Runtime.ExceptionServices;
using DevElf.ArgumentValidation;

namespace DevElf.Extensions;

/// <summary>
/// Provides extension methods for delegates.
/// </summary>
public static class LambdaExtensions
{
    /// <summary>
    /// Wraps an <see cref="Action"/> so that if it throws an exception that contains
    /// inner exceptions, the innermost exception is re-thrown while preserving the
    /// original stack trace.
    /// </summary>
    /// <param name="action">The action to execute.</param>
    /// <returns>
    /// A new <see cref="Action"/> that executes <paramref name="action"/> and, when an
    /// exception occurs, re-throws the innermost exception.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    public static Action UnwrapAndReThrow(this Action action)
    {
        action.ThrowIfNull();

        return () =>
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Exception lastEx = ex;

                while (lastEx.InnerException != null)
                {
                    lastEx = lastEx.InnerException;
                }

                ExceptionDispatchInfo.Capture(lastEx).Throw();
            }
        };
    }

    /// <summary>
    /// Wraps a <see cref="Func{TResult}"/> so that if it throws an exception that
    /// contains inner exceptions, the innermost exception is re-thrown while preserving
    /// the original stack trace.
    /// </summary>
    /// <typeparam name="T">The result type of the function.</typeparam>
    /// <param name="function">The function to execute.</param>
    /// <returns>
    /// A new <see cref="Func{TResult}"/> that executes <paramref name="function"/> and, when an
    /// exception occurs, re-throws the innermost exception.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="function"/> is <see langword="null"/>.
    /// </exception>
    public static Func<T> UnwrapAndReThrow<T>(this Func<T> function)
    {
        function.ThrowIfNull();

        return () =>
        {
            try
            {
                return function();
            }
            catch (Exception ex)
            {
                Exception lastEx = ex;

                while (lastEx.InnerException != null)
                {
                    lastEx = lastEx.InnerException;
                }

                ExceptionDispatchInfo.Capture(lastEx).Throw();
            }

            // This line is unreachable but required to satisfy all return paths.
            return default;
        };
    }
}
