namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public class MainFormViewModel
{
    public MainFormViewModel()
    {
        GridViewModel = new(TilesetViewModel);
        SimulationViewModel = new(TilesetViewModel, GridViewModel);
    }

    public TilesetViewModel TilesetViewModel { get; private init; } = new();
    public GridViewModel GridViewModel { get; private init; }
    public SimulationViewModel SimulationViewModel { get; private init; }
}