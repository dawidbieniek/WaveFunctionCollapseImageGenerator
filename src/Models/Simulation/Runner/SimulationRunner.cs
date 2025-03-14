﻿using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Exceptions;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Runner;

public partial class SimulationRunner(IWFCSimulation simulation) : ObservableObject
{
    public readonly IWFCSimulation _simulation = simulation;

    private readonly Lock _simulationStepLock = new();

    private readonly CancellationTokenSource _loopCts = new();
    private readonly SemaphoreSlim _loopPauseSemaphore = new(0, 1);

    [ObservableProperty]
    private bool _isSimulationStarted = false;
    [ObservableProperty]
    private bool _isSimulationRunning = false;
    [ObservableProperty]
    private bool _canContinueSimulation = false;

    private Task? _loopTask;

    public event SimulationStepEventHandler SimulationStep = delegate { };
    public event EventHandler<CellGrid> BacktrackingStackEmptyError = delegate { };
    public event InvalidCellCollapseEventHandler InvalidCellCollapseError = delegate { };
    public event SimulationStepEventHandler SimulationFinished = delegate { };
    public event EventHandler<CellGrid> SimulationPaused = delegate { };

    public void StepSimulation()
    {
        if (!IsSimulationStarted)
            StartSimulation();

        if (!CanContinueSimulation)
            return;

        DoSimulationStep();
    }

    public void ContinueSimulation()
    {
        if (!IsSimulationStarted)
            StartSimulation();

        if (IsSimulationRunning || !CanContinueSimulation)
            return;

        if (_loopTask is null)
            _loopTask = Task.Run(RunnerLoop, _loopCts.Token);

        _loopPauseSemaphore.Release();
        IsSimulationRunning = true;
    }

    public async Task PauseSimulationAsync()
    {
        await _loopPauseSemaphore.WaitAsync();
        IsSimulationRunning = false;

        SimulationPaused?.Invoke(this, _simulation.Grid);
    }

    public void StopSimulation()
    {
        _loopCts.Cancel();
        _loopTask = null;

        IsSimulationStarted = false;
        IsSimulationRunning = false;
        CanContinueSimulation = false;
    }

    private void StartSimulation()
    {
        IsSimulationStarted = true;
        CanContinueSimulation = true;
    }

    private void DoSimulationStep()
    {
        try
        {
            using (_simulationStepLock.EnterScope())
            {
                _simulation.Step();
                SimulationStep?.Invoke(this, new(_simulation.Grid));

                if (_simulation.IsFinished)
                {
                    _loopCts.Cancel();
                    IsSimulationRunning = false;
                    CanContinueSimulation = false;
                    SimulationFinished?.Invoke(this, new(_simulation.Grid));
                }
            }
        }
        catch (InvalidCellCollapseException ex)
        {
            _loopCts.Cancel();
            CanContinueSimulation = false;
            InvalidCellCollapseError?.Invoke(this, new(ex, _simulation.Grid));
        }
        catch (BacktrackingStackEmptyException)
        {
            _loopCts.Cancel();
            CanContinueSimulation = false;
            BacktrackingStackEmptyError?.Invoke(this, _simulation.Grid);
        }
    }

    private async Task RunnerLoop()
    {
        try
        {
            while (!_loopCts.IsCancellationRequested)
            {
                await _loopPauseSemaphore.WaitAsync();

                DoSimulationStep();

                _loopPauseSemaphore.Release();
            }
        }
        catch (OperationCanceledException)
        { }
    }
}