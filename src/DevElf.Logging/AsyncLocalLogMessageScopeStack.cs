namespace DevElf.Logging;

internal sealed class AsyncLocalLogMessageScopeStack
{
    private static readonly AsyncLocal<Stack<LogMessageScope>?> Local = new();

    private static Stack<LogMessageScope> ScopeStack => Local.Value ??= new Stack<LogMessageScope>();

    public static int Count => ScopeStack.Count;

    public static void Push(LogMessageScope item) => ScopeStack.Push(item);

    public static LogMessageScope Pop() => ScopeStack.Pop();

    public static LogMessageScope? Peek() => ScopeStack.Count > 0 ? ScopeStack.Peek() : default;
}
