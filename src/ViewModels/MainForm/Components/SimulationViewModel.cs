using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Models.Exceptions;
using WaveFunctionCollapseImageGenerator.Models.Simulation;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class SimulationViewModel : ObservableObject
{
    private readonly ILogger _logger;

    private readonly ITilesetProvider _tilesetProvider;
    private readonly IGridProvider _gridProvider;

    private readonly TileGridImageDrawer _displayImageDrawer;

    private readonly WFCSimulationFactory _wfcSimulationFactory;

    private IWFCSimulation? _simulation;
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

    [ObservableProperty]
    private bool _canContinueSimulation = true;

    public SimulationViewModel(ITilesetProvider tilesetProvider, IGridProvider gridProvider, ILoggerFactory loggerFactory)
    {
        _tilesetProvider = tilesetProvider;
        _gridProvider = gridProvider;
        _logger = loggerFactory.CreateLogger<SimulationViewModel>();

        _wfcSimulationFactory = new(loggerFactory);

        _displayImageDrawer = new(_tilesetProvider.Tileset);
    }

    public bool UseSeed => !RandomizeSeed && !SimulationStarted;

    [RelayCommand]
    public void StepSimulation()
    {
        if (!SimulationStarted)
            StartSimulation();

        if (!CanContinueSimulation)
            return;

        try
        {
            _simulation!.Step();
            Image image = _displayImageDrawer.DrawTileGrid(_gridProvider.Grid!);
            DisplayImageSize = image.Size;
            DisplayImage = image;
        }
        catch (InvalidCellCollapseException ex)
        {
            _logger.LogError("Simulation stopped: {message}", ex.Message);
            CanContinueSimulation = false;
            Image image = _displayImageDrawer.DrawTileGridWithInvalidCellIndicator(_gridProvider.Grid!, ex.InvalidCell.X, ex.InvalidCell.Y);
            DisplayImage = image;
        }
        catch (BacktrackingStackEmptyException)
        {
            _logger.LogError("Simulation stopped: simulation needs to backtrack, but snapshot stack is empty. Consider using bigger stack size");
            CanContinueSimulation = false;
        }

    }

    [RelayCommand]
    public void ResetSimulation()
    {
        if (!SimulationStarted)
            return;

        SimulationStarted = false;
        CanContinueSimulation = true;

        _gridProvider.UnlockChanges();


        _logger.LogInformation("Simulation reset");
    }

    private void StartSimulation()
    {
        SimulationStarted = true;

        _random = RandomizeSeed ? new Random() : new Random(Seed);
        _simulation = _wfcSimulationFactory.CreateSimulation(_gridProvider.CreateGrid(_random), _tilesetProvider.Tileset.Ruleset, _random, UseBacktracking, BacktrackingDepth);
        _gridProvider.LockChanges();

        _logger.LogInformation("Simulation started");
    }
}