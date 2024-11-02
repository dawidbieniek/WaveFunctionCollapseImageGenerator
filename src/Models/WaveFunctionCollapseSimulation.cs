using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Models;

// TODO: Backtracking at level of simulation
public class WaveFunctionCollapseSimulation(CellGrid grid, Ruleset ruleset)
{
    private readonly CellGrid _grid = grid;
    private readonly Ruleset _ruleset = ruleset;

    private readonly Random _random = new();

    // Possible improvements:
    // TODO: Multiple collapses per step
    // TODO: Separate collection for lowest entropy cells - store instead of iterate
    public void Step()
    {
        // Find cell to collapse
        IList<(Cell cell, int x, int y)> potentialCells = _grid.GetLowestEntropyCollapsableCellsWithCoordinates();
        (Cell cell, int x, int y) = potentialCells[_random.Next(potentialCells.Count)];

        // Collapse cell and update neighbours' possible states
        int cellState = cell.Collapse();

        (Cell? up, Cell? right, Cell? down, Cell? left) = _grid.GetNeighboursOfCell(x, y);
        UpdateNeighbour(up, Direction.Up, cellState);
        UpdateNeighbour(right, Direction.Right, cellState);
        UpdateNeighbour(down, Direction.Down, cellState);
        UpdateNeighbour(left, Direction.Left, cellState);
    }

    private void UpdateNeighbour(Cell? neighbour, Direction neighbourDirection, int originalCellState)
    {
        if (neighbour == null || neighbour.Collapsed)
            return;

        neighbour.RemoveStates(_ruleset.DisallowedNeighbours[(originalCellState, neighbourDirection)]);
    }
}