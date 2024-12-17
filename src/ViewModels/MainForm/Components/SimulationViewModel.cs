using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Models.Simulation;
using WaveFunctionCollapseImageGenerator.Models.Simulation.Runner;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class SimulationViewModel : ObservableObject
{
    private readonly ILogger _logger;

    private readonly ITilesetProvider _tilesetProvider;
    private readonly IGridProvider _gridProvider;
    private readonly IImageDisplayer _imageDisplayer;
    private readonly WFCSimulationFactory _wfcSimulationFactory;

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
    private bool _enableRunButton = true;
    [ObservableProperty]
    private bool _enablePauseButton = true;
    [ObservableProperty]
    private bool _enableStepButton = true;
    [ObservableProperty]
    private bool _enableResetButton = true;

    [ObservableProperty]
    private bool _skipDrawingUntilFinished = false;

    private SimulationRunner? _simulationRunner;

    public SimulationViewModel(ITilesetProvider tilesetProvider, IGridProvider gridProvider, IImageDisplayer imageDisplayer, ILoggerFactory loggerFactory)
    {
        _tilesetProvider = tilesetProvider;
        _gridProvider = gridProvider;
        _imageDisplayer = imageDisplayer;
        _logger = loggerFactory.CreateLogger<SimulationViewModel>();

        _wfcSimulationFactory = new(loggerFactory);

        UpdateButtonEnablement();
    }

    public bool UseSeed => !RandomizeSeed;

    [RelayCommand]
    public void StepSimulation()
    {
        if (_tilesetProvider.Tileset is null)
            return;
        if (_simulationRunner is null)
            CreateSimulation();

        _simulationRunner!.StepSimulation();
    }

    [RelayCommand]
    public void ResetSimulation()
    {
        if (_simulationRunner is null)
            return;

        _simulationRunner.StopSimulation();
        _simulationRunner = null;

        UpdateButtonEnablement();
        _gridProvider.UnlockChanges();
        _imageDisplayer.ClearImage();

        _logger.LogInformation("Simulation reset");
    }

    [RelayCommand]
    public void RunSimulation()
    {
        if (_tilesetProvider.Tileset is null)
            return;
        if (_simulationRunner is null)
            CreateSimulation();

        _simulationRunner!.ContinueSimulation();

        _logger.LogInformation("Simulation started");
    }

    [RelayCommand]
    public async Task PauseSimulation()
    {
        if (_simulationRunner is null)
            return;

        if (_simulationRunner.IsSimulationRunning)
        {
            await _simulationRunner.PauseSimulationAsync();
            _logger.LogInformation("Simulation paused");
        }
    }

    private void CreateSimulation()
    {
        if (RandomizeSeed)
            Seed = (new Random()).Next();

        Random random = new(Seed);

        _simulationRunner = new(_wfcSimulationFactory.CreateSimulation(_gridProvider.CreateGrid(random)!, _tilesetProvider.Tileset!.Ruleset, random, UseBacktracking, BacktrackingDepth));
        // Relaying property changes
        _simulationRunner.PropertyChanged += (s, e) => Application.OpenForms[0]!.Invoke(() =>
        {
            switch (e.PropertyName)
            {
                case nameof(_simulationRunner.IsSimulationRunning):
                case nameof(_simulationRunner.IsSimulationStarted):
                case nameof(_simulationRunner.CanContinueSimulation):
                    UpdateButtonEnablement();
                    break;
            }
        });
        _simulationRunner.SimulationStep += (s, e) => Application.OpenForms[0]!.Invoke(() =>
        {
            if (!SkipDrawingUntilFinished)
                _imageDisplayer.DisplayGrid(e.CurrentSimulationCellGrid);
        });
        _simulationRunner.BacktrackingStackEmptyError += (s, e) => Application.OpenForms[0]!.Invoke(() =>
        {
            if (SkipDrawingUntilFinished)
                _imageDisplayer.DisplayGrid(e);

            _logger.LogError("Simulation stopped: simulation needs to backtrack, but snapshot stack is empty. Consider using bigger stack size");
            UpdateButtonEnablement();
        });
        _simulationRunner.InvalidCellCollapseError += (s, e) => Application.OpenForms[0]!.Invoke(() =>
        {
            _logger.LogError("Simulation stopped: {message}", e.Exception.Message);
            UpdateButtonEnablement();

            _imageDisplayer.DisplayGridWithErrorCell(e.SimulationCellGrid, e.Exception.InvalidCell.X, e.Exception.InvalidCell.Y);
        });
        _simulationRunner.SimulationFinished += (s, e) => Application.OpenForms[0]!.Invoke(() =>
        {
            if (SkipDrawingUntilFinished)
                _imageDisplayer.DisplayGrid(e.CurrentSimulationCellGrid);
            _logger.LogInformation("Simulation finished");
        });
        _simulationRunner.SimulationPaused += (s, e) =>
        {
            if (SkipDrawingUntilFinished)
                _imageDisplayer.DisplayGrid(e);
        };

        _gridProvider.LockChanges();

        _logger.LogInformation("Simulation created");
    }

    private void UpdateButtonEnablement()
    {
        if (_simulationRunner is null)
        {
            EnableRunButton = true;
            EnablePauseButton = false;
            EnableStepButton = true;
            EnableResetButton = false;
            return;
        }

        EnableRunButton = !_simulationRunner.IsSimulationRunning && _simulationRunner.CanContinueSimulation;
        EnablePauseButton = _simulationRunner.IsSimulationStarted && _simulationRunner.IsSimulationRunning;
        EnableStepButton = EnableRunButton;
        EnableResetButton = _simulationRunner.IsSimulationStarted;
    }
}