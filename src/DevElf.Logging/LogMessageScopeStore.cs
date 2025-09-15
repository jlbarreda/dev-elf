namespace DevElf.Logging;

public sealed class LogMessageScopeStore<T> : ILogMessageScopeStore<T>
{
    private readonly Stack<T> _stack = new();

    public int Count => _stack.Count;

    public void Push(T item) => _stack.Push(item);

    public T Pop() => _stack.Pop();

    public T? Peek() => _stack.Count > 0 ? _stack.Peek() : default;
}
