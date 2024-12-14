using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class MainFormViewModel(TilesetViewModel tilesetViewModel, GridViewModel gridViewModel, SimulationViewModel simulationViewModel, ImageViewModel imageViewModel)
{
    public TilesetViewModel TilesetViewModel { get; } = tilesetViewModel;
    public GridViewModel GridViewModel { get; } = gridViewModel;
    public SimulationViewModel SimulationViewModel { get; } = simulationViewModel;
    public ImageViewModel ImageViewModel { get; } = imageViewModel;

    public async Task InitializeAsync()
    {
        await TilesetViewModel.InitializeAsync();
    }
}