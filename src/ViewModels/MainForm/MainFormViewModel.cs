using System.Drawing;

using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Common.Loggers;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class MainFormViewModel : ObservableObject
{
    [ObservableProperty]
    private string _logConsoleText = string.Empty;

    public TilesetViewModel TilesetViewModel { get; private init; }
    public GridViewModel GridViewModel { get; private init; }
    public SimulationViewModel SimulationViewModel { get; private init; }

    public MainFormViewModel(TilesetViewModel tilesetViewModel, GridViewModel gridViewModel, SimulationViewModel simulationViewModel, IEventLogPublihser logPublisher)
    {
        TilesetViewModel = tilesetViewModel;
        GridViewModel = gridViewModel;
        SimulationViewModel = simulationViewModel;

        logPublisher.Logged += OnNewLogRecieved;
    }

    // HACK: There probably will be problem when recieving messages from other threads
    private void OnNewLogRecieved(object sender, EventLoggerEventArgs args) => LogConsoleText += $"{args.Message}{Environment.NewLine}";
}