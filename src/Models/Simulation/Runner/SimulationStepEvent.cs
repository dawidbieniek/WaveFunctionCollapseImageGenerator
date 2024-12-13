using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Runner;

public class SimulationStepEventArgs(CellGrid simulationCellGrid) : EventArgs
{
    public CellGrid CurrentSimulationCellGrid { get; set; } = simulationCellGrid;
}

public delegate void SimulationStepEventHandler(object sender, SimulationStepEventArgs e);