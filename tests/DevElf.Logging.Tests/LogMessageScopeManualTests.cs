using Microsoft.Extensions.Logging;

namespace DevElf.Logging.Tests;

[TestClass]
public class LogMessageScopeManualTests
{
    // This test is mainly to demonstrate usage and manually verify the output.
    [TestMethod]
    public void Test()
    {
        ILogger logger = LoggerFactory
            .Create(builder => _ = builder.AddJsonConsole(options => options.IncludeScopes = true))
            .CreateLogger("TestLogger");
        var scopeAccessor = new LogMessageScopeAccessor();

        using (var scope = logger.BeginMessageScope(LogLevel.Information, "Test message"))
        {
            _ = scope.SetProperty("Key", "Value");

            using (logger.BeginScope(new Dictionary<string, object?> { { "ExternalKey", "ExternalValue" } }))
            using (var nestedScope = logger.BeginMessageScope(LogLevel.Warning, "Nested message"))
            {
                _ = nestedScope.SetProperty("NestedKey", 123);

                var x = new X(scopeAccessor, logger);

                x.Y();

                x.Z();
            }
        }
    }

    public class X
    {
        private readonly ILogMessageScopeAccessor _logMessageScopeAccessor;
        private readonly ILogger _logger;

        public X(ILogMessageScopeAccessor logMessageScopeAccessor, ILogger logger)
        {
            using (var scope = logger.BeginMessageScope(LogLevel.Information, "Test message from X"))
            {
                _ = scope.SetProperty("XKey", "XValue");
            }

            _logMessageScopeAccessor = logMessageScopeAccessor;
            _logger = logger;
        }

        public void Y()
        {
            using (var scope = _logger.BeginMessageScope(LogLevel.Error, "Error message from Y"))
            {
                _ = scope.SetProperty("YKey", "YValue");
            }
        }

        public void Z() => _logMessageScopeAccessor.Current?.SetProperty("ZKey", "ZValue");
    }
}
