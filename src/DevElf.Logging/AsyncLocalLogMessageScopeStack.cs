namespace DevElf.Logging;

/// <summary>
/// Ambient async-local stack of <see cref="LogMessageScope"/> instances.
/// Disposed scopes are skipped, so a scope disposed out of order (or from another execution context)
/// never remains the current scope.
/// </summary>
internal static class AsyncLocalLogMessageScopeStack
{
    private static readonly AsyncLocal<ScopeNode?> Local = new();

    public static LogMessageScope? Peek() => Compact()?.Scope;

    public static void Push(LogMessageScope scope) => Local.Value = new ScopeNode(scope, SkipDisposed(Local.Value));

    /// <summary>
    /// Pops <paramref name="scope"/> if it is the top-most active scope.
    /// </summary>
    /// <returns><see langword="true"/> if the scope was popped; otherwise <see langword="false"/>.</returns>
    public static bool TryPop(LogMessageScope scope)
    {
        ScopeNode? node = Local.Value;

        // The scope being popped may already be flagged as disposed, so it must not be skipped.
        while (node is not null && !ReferenceEquals(node.Scope, scope) && node.Scope.IsDisposed)
        {
            node = node.Parent;
        }

        if (node is null || !ReferenceEquals(node.Scope, scope))
        {
            return false;
        }

        Local.Value = SkipDisposed(node.Parent);

        return true;
    }

    /// <summary>
    /// Drops any disposed scopes from the top of the stack so later reads don't traverse them again.
    /// </summary>
    private static ScopeNode? Compact()
    {
        ScopeNode? current = Local.Value;
        ScopeNode? node = SkipDisposed(current);

        // Only write when there is something to drop; every AsyncLocal write allocates a new ExecutionContext.
        if (!ReferenceEquals(node, current))
        {
            Local.Value = node;
        }

        return node;
    }

    private static ScopeNode? SkipDisposed(ScopeNode? node)
    {
        while (node is not null && node.Scope.IsDisposed)
        {
            node = node.Parent;
        }

        return node;
    }

    private sealed class ScopeNode(LogMessageScope scope, ScopeNode? parent)
    {
        public LogMessageScope Scope { get; } = scope;

        public ScopeNode? Parent { get; } = parent;
    }
}
