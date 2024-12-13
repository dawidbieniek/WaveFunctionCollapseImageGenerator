using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Exceptions;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Runner;

public class InvalidCellCollapseEventArgs(InvalidCellCollapseException exception, CellGrid simulationCellGrid) : EventArgs
{
    public InvalidCellCollapseException Exception { get; set; } = exception;
    public CellGrid SimulationCellGrid { get; set; } = simulationCellGrid;
}

public delegate void InvalidCellCollapseEventHandler(object sender, InvalidCellCollapseEventArgs e);