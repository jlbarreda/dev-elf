namespace DevElf.Logging;

/// <summary>
/// Async-local implementation of <see cref="ILogMessageScopeStore{T}"/>.
/// Maintains a separate LIFO stack per async context and flows across async/await.
/// </summary>
public sealed class AsyncLocalLogMessageScopeStore<T> : ILogMessageScopeStore<T>
{
    private static readonly AsyncLocal<Stack<T>?> Local = new();

    private static Stack<T> Stack => Local.Value ??= new Stack<T>();

    public int Count => Stack.Count;

    public void Push(T item) => Stack.Push(item);

    public T Pop() => Stack.Pop();

    public T? Peek() => Stack.Count > 0 ? Stack.Peek() : default;
}
