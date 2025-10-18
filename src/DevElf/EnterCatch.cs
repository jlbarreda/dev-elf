using DevElf.ArgumentValidation;

namespace DevElf;

/// <summary>
/// Provides helper methods for executing actions in catch block filter conditions.
/// Allows running actions (such as logging) while preserving the original exception
/// context and controlling whether to enter the catch block.
/// </summary>
/// <remarks>
/// <para>
/// These methods are designed to be used in catch block <c>when</c> clauses to
/// execute side-effect actions (typically logging) at the point where the exception
/// occurs, before the stack unwinds further. The return value determines whether
/// the catch block should be entered.
/// </para>
/// <para>
/// <strong>Important:</strong> These methods do not work well with async code.
/// When an exception is thrown in an async method, it is caught by the async
/// state machine and re-thrown at the point of the <c>await</c>. This causes
/// the exception filter to run at the await location rather than where the
/// exception was originally thrown, losing the original exception context and
/// stack trace information that these methods are designed to preserve.
/// </para>
/// <para>
/// This implementation is based on the concept described by Stephen Cleary in
/// "A New Pattern for Exception Logging":
/// https://blog.stephencleary.com/2020/06/a-new-pattern-for-exception-logging.html
/// </para>
/// </remarks>
/// <example>
/// <code>
/// try
/// {
///     // Code that might throw
/// }
/// catch (Exception ex) when (EnterCatch.AfterAction(() => logger.LogError(ex)))
/// {
///     // Handle exception with full context preserved
/// }
/// </code>
/// </example>
public static class EnterCatch
{
    /// <summary>
    /// Executes an action and always returns <see langword="false"/>, preventing
    /// the catch block from being entered.
    /// </summary>
    /// <param name="action">The action to execute in the filter condition.</param>
    /// <returns>
    /// Always returns <see langword="false"/>, causing the exception to continue
    /// propagating.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// If <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method is useful when you want to perform an action (such as logging)
    /// in the exception filter but do not want to handle the exception. The
    /// exception will continue to propagate up the call stack.
    /// </remarks>
    /// <example>
    /// <code>
    /// try
    /// {
    ///     // Code that might throw
    /// }
    /// catch (Exception ex) when (EnterCatch.Never(() => logger.LogWarning(ex)))
    /// {
    ///     // This block will never execute
    /// }
    /// </code>
    /// </example>
    public static bool Never(Action action)
    {
        action.ThrowIfNull();

        action();

        return false;
    }

    /// <summary>
    /// Executes an action and always returns <see langword="true"/>, causing the
    /// catch block to be entered.
    /// </summary>
    /// <param name="action">The action to execute in the filter condition.</param>
    /// <returns>
    /// Always returns <see langword="true"/>, causing the catch block to be
    /// entered.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// If <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method allows you to execute an action (such as logging) in the
    /// exception filter before entering the catch block, preserving the original
    /// exception context.
    /// </remarks>
    /// <example>
    /// <code>
    /// try
    /// {
    ///     // Code that might throw
    /// }
    /// catch (Exception ex) when (EnterCatch.AfterAction(() => logger.LogError(ex)))
    /// {
    ///     // Handle the exception
    ///     return fallbackValue;
    /// }
    /// </code>
    /// </example>
    public static bool AfterAction(Action action)
    {
        action.ThrowIfNull();

        action();

        return true;
    }

    /// <summary>
    /// Executes an action and then evaluates a condition to determine whether the
    /// catch block should be entered.
    /// </summary>
    /// <param name="action">The action to execute in the filter condition.</param>
    /// <param name="condition">
    /// The function that determines whether to enter the catch block.
    /// </param>
    /// <returns>
    /// The result of evaluating <paramref name="condition"/>, which determines
    /// whether the catch block is entered.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// If <paramref name="action"/> or <paramref name="condition"/> is
    /// <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// This method allows you to execute an action (such as logging) and then
    /// conditionally decide whether to handle the exception based on runtime
    /// conditions.
    /// </remarks>
    /// <example>
    /// <code>
    /// try
    /// {
    ///     // Code that might throw
    /// }
    /// catch (Exception ex) when (EnterCatch.AfterActionIf(
    ///     () => logger.LogError(ex),
    ///     () => retryCount &lt; maxRetries))
    /// {
    ///     // Only handle if retryCount is less than maxRetries
    ///     retryCount++;
    /// }
    /// </code>
    /// </example>
    public static bool AfterActionIf(Action action, Func<bool> condition)
    {
        action.ThrowIfNull();
        condition.ThrowIfNull();

        action();

        return condition();
    }
}
