using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WaveFunctionCollapseImageGenerator.Common.Loggers;

internal static class EventLoggerExtensions
{
    public static ILoggingBuilder AddRtbLogger(this ILoggingBuilder builder)
    {
        builder.Services.AddSingleton<EventLoggerProvider>();
        builder.Services.AddSingleton<ILoggerProvider>(sp => sp.GetRequiredService<EventLoggerProvider>()!);
        builder.Services.AddSingleton<IEventLogPublihser>(sp => sp.GetRequiredService<EventLoggerProvider>()!);
        return builder;
    }
}