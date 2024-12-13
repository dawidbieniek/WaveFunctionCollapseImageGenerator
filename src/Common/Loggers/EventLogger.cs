using Microsoft.Extensions.Logging;

namespace WaveFunctionCollapseImageGenerator.Common.Loggers;

public class EventLogger(ILogEventRaiser logEventRaiser) : ILogger
{
    private readonly ILogEventRaiser _logEventRaiser = logEventRaiser;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel))
            return;

        string logRecord = string.Format("[{0}] [{1}] {2} {3}", logLevel.ToString()[..3].ToUpperInvariant(), DateTime.Now.ToString("HH:mm:ss"), formatter(state, exception), exception != null ? exception.StackTrace : "");
        _logEventRaiser.RaiseLoggedEvent(logRecord, logLevel);
    }
}