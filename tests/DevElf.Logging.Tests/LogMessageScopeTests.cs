using Microsoft.Extensions.Logging;

namespace DevElf.Logging.Tests;

[TestClass]
public class LogMessageScopeTests
{
    [TestMethod]
    public void Test()
    {
        ILogMessageScopeFactory factory = new LogMessageScopeFactory();
        ILogger logger = LoggerFactory
            .Create(builder =>
            {
                builder.AddJsonConsole(options => { options.IncludeScopes = true; });
            })
            .CreateLogger("TestLogger");

        using (var scope = factory.Create(logger, LogLevel.Information, "Test message"))
        {
            _ = scope.SetProperty("Key", "Value");

            using (var nestedScope = factory.Create(logger, LogLevel.Warning, "Nested message"))
            {
                _ = nestedScope.SetProperty("NestedKey", 123);
            }
        }
    }
}
