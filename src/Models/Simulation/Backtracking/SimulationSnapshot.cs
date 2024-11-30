using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Backtracking;
public record SimulationSnapshot(Cell[,] GridCells, int CellX, int CellY, int CellCollapseState);