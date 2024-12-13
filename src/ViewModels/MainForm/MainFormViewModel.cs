using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class MainFormViewModel(TilesetViewModel tilesetViewModel, GridViewModel gridViewModel, SimulationViewModel simulationViewModel, ImageViewModel imageViewModel)
{
    public TilesetViewModel TilesetViewModel { get; private init; } = tilesetViewModel;
    public GridViewModel GridViewModel { get; private init; } = gridViewModel;
    public SimulationViewModel SimulationViewModel { get; private init; } = simulationViewModel;
    public ImageViewModel ImageViewModel { get; private init; } = imageViewModel;
}