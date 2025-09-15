namespace DevElf.Logging;

public interface ILogMessageScopeStore<T>
{
    void Push(T item);

    T Pop();

    T? Peek();

    int Count { get; }
}
