namespace WaveFunctionCollapseImageGenerator.Common.Loggers;

public class EventLoggerEventArgs(string message) : EventArgs
{
    public string Message { get; set; } = message;
}

public delegate void EventLoggerEventHandler(object sender, EventLoggerEventArgs args);