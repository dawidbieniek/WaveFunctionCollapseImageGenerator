using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using WaveFunctionCollapseImageGenerator.Models;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class SimulationViewModel : ObservableObject
{
    private readonly ITilesetProvider _tilesetProvider;
    private readonly IGridProvider _gridProvider;

    private TileGridImageDrawer _displayImageDrawer;

    private WaveFunctionCollapseSimulation _simulation;

    [ObservableProperty]
    private Image _displayImage = new Bitmap(100, 100);
    [ObservableProperty]
    private Size _displayImageSize = new(100, 100);

    public SimulationViewModel(ITilesetProvider tilesetProvider, IGridProvider gridProvider)
    {
        _tilesetProvider = tilesetProvider;
        _gridProvider = gridProvider;

        _displayImageDrawer = new(_tilesetProvider.Tileset);

        _simulation = new(_gridProvider.Grid, _tilesetProvider.Tileset.Ruleset);
    }

    [RelayCommand]
    public void StepSimulation()
    {
        for (int i = 0; i < 10; i++)
            _simulation.Step();
        Image image = _displayImageDrawer.DrawTileGrid(_gridProvider.Grid);
        DisplayImageSize = image.Size;
        DisplayImage = image;
    }

    [RelayCommand]
    public void ResetSimulation()
    {
    }
}