using Microsoft.Extensions.Logging;

namespace DevElf.Logging;

public interface ILogMessageScope : IDisposable
{
    T SetProperty<T>(string key, T value);

    void SetException(Exception exception);

    void ChangeLogLevel(LogLevel logLevel);

    void ChangeEventId(EventId eventId);

    void ChangeMessage(string message);
}
