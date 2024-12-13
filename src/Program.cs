using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Common.Loggers;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        IHostBuilder builder = Host.CreateDefaultBuilder();

        builder.ConfigureLogging((ILoggingBuilder logging) =>
        {
            logging.ClearProviders();
            logging.AddRtbLogger();
        });

        builder.ConfigureServices((context, services) => ConfigureServices(services));

        IHost app = builder.Build();
        ServiceProvider = app.Services;

        Application.Run(ServiceProvider.GetRequiredService<MainForm>());
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MainFormViewModel>()
            .AddSingleton<TilesetViewModel>()
            .AddSingleton<GridViewModel>()
            .AddSingleton<ImageViewModel>()
            .AddSingleton<ITilesetProvider>(sp => sp.GetRequiredService<TilesetViewModel>())
            .AddSingleton<IGridProvider>(sp => sp.GetRequiredService<GridViewModel>())
            .AddSingleton<IImageDisplayer>(sp => sp.GetRequiredService<ImageViewModel>())
            .AddSingleton<SimulationViewModel>();

        services.AddSingleton<MainForm>();
    }
}