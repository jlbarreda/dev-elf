namespace DevElf.Logging;

internal sealed class AsyncLocalLogMessageScopeStack
{
    private static readonly AsyncLocal<ScopeNode?> Local = new();

    public static int Count => Local.Value?.Count ?? 0;

    public static void Push(LogMessageScope item) => Local.Value = new ScopeNode(item, Local.Value);

    public static LogMessageScope Pop()
    {
        ScopeNode node = Local.Value ?? throw new InvalidOperationException("The scope stack is empty.");
        Local.Value = node.Parent;

        return node.Scope;
    }

    public static LogMessageScope? Peek() => Local.Value?.Scope;

    private sealed class ScopeNode(LogMessageScope scope, ScopeNode? parent)
    {
        public LogMessageScope Scope { get; } = scope;

        public ScopeNode? Parent { get; } = parent;

        public int Count { get; } = (parent?.Count ?? 0) + 1;
    }
}
