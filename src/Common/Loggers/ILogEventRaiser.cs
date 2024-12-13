using Microsoft.Extensions.Logging;

namespace WaveFunctionCollapseImageGenerator.Common.Loggers;
public interface ILogEventRaiser
{
    void RaiseLoggedEvent(string logRecord, LogLevel logLevel);
}
