using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using WaveFunctionCollapseImageGenerator.Models;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class SimulationViewModel : ObservableObject
{
    private readonly ITilesetProvider _tilesetProvider;
    private readonly IGridProvider _gridProvider;

    private readonly TileGridImageDrawer _displayImageDrawer;

    private WaveFunctionCollapseSimulation? _simulation;
    private Random? _random;

    [ObservableProperty]
    private bool _useBacktracking = false;
    [ObservableProperty]
    private int _backtrackingDepth = 10;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(UseSeed))]
    private bool _randomizeSeed = true;
    [ObservableProperty]
    private int _seed = 0;

    [ObservableProperty]
    private Image _displayImage = new Bitmap(100, 100);
    [ObservableProperty]
    private Size _displayImageSize = new(100, 100);

    //TODO: Bind to some text display that says the simulation is running
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(UseSeed))]
    private bool _simulationStarted = false;

    public SimulationViewModel(ITilesetProvider tilesetProvider, IGridProvider gridProvider)
    {
        _tilesetProvider = tilesetProvider;
        _gridProvider = gridProvider;

        _displayImageDrawer = new(_tilesetProvider.Tileset);
    }

    public bool UseSeed => !RandomizeSeed && !SimulationStarted;

    [RelayCommand]
    public void StepSimulation()
    {
        if (!SimulationStarted)
            StartSimulation();

        for (int i = 0; i < 10; i++)
            _simulation!.Step();
        Image image = _displayImageDrawer.DrawTileGrid(_gridProvider.Grid!);
        DisplayImageSize = image.Size;
        DisplayImage = image;
    }

    [RelayCommand]
    public void ResetSimulation()
    {
        SimulationStarted = false;

        _gridProvider.UnlockChanges();
    }

    private void StartSimulation()
    {
        SimulationStarted = true;

        _random = RandomizeSeed ? new Random() : new Random(Seed);
        _simulation = new(_gridProvider.CreateGrid(_random), _tilesetProvider.Tileset.Ruleset, _random);
        _gridProvider.LockChanges();
    }
}