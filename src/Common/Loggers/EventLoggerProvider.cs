using Microsoft.Extensions.Logging;

namespace WaveFunctionCollapseImageGenerator.Common.Loggers;

[ProviderAlias("EventLogger")]
public class EventLoggerProvider : ILoggerProvider, IEventLogPublihser, ILogEventRaiser
{
    public event EventLoggerEventHandler Logged = delegate { };

    public ILogger CreateLogger(string categoryName) => new EventLogger(this);

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public void RaiseLoggedEvent(string logRecord, LogLevel logLevel)
    {
        Logged?.Invoke(this, new(logRecord));
    }
}