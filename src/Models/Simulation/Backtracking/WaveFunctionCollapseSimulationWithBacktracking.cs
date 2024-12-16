using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Common;
using WaveFunctionCollapseImageGenerator.Models.Exceptions;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Backtracking;

public class WaveFunctionCollapseSimulationWithBacktracking(CellGrid grid, Ruleset ruleset, Random random, int snapshotStackSize, ILogger<WaveFunctionCollapseSimulationWithBacktracking> logger) : WaveFunctionCollapseSimulation(grid, ruleset, random)
{
    private readonly ILogger<WaveFunctionCollapseSimulationWithBacktracking> _logger = logger;

    private readonly DropoutStack<SimulationSnapshot> _snapshotStack = new(snapshotStackSize);

    public override void Step()
    {
        // Find cell to collapse
        IList<CellWithCoordinates> potentialCells = Grid.GetLowestEntropyCollapsableCellsWithCoordinates();
        int collapsingCellIndex = Random.Next(potentialCells.Count);
        CellWithCoordinates cell = potentialCells[collapsingCellIndex];

        if (!BacktrackingStep(cell))
            throw new BacktrackingStackEmptyException();
    }

    private bool BacktrackingStep(CellWithCoordinates cell)
    {
        Cell dryRunCell = new(cell.Cell);

        while (dryRunCell.CanBeCollapsed)
        {
            // Double cloning is necessary for keeping track of already tried states
            int cellState = new Cell(dryRunCell).Collapse();

            if (WillNeighboursBeValidAfterCollapse(cell.X, cell.Y, cellState))
            {
                _snapshotStack.Push(new(Grid.CreateCellSnapshot(), cell.X, cell.Y, cellState));

                cell.Cell.Collapse(cellState);
                UpdateNeighbours(cell.X, cell.Y, cellState);

                return true;
            }

            // Current state leads to invalidity -> remove it and try again
            dryRunCell.RemoveStates(cellState);
        }
        // If exited above loop -> there is problem with current cell collapse; need to backtrack to
        // previous snapshot

        if (_snapshotStack.Count <= 0)
            return false;

        CellWithCoordinates snapshotCell = ApplySnapshot(_snapshotStack.Pop());
        _logger.LogInformation("Backtracking: {count} snapshots left", _snapshotStack.Count);

        return BacktrackingStep(snapshotCell);
    }

    private bool WillNeighboursBeValidAfterCollapse(int x, int y, int cellState)
    {
        (Cell? up, Cell? right, Cell? down, Cell? left) = Grid.GetNeighboursOfCell(x, y);

        return WillNeighbourBeValidAfterCollapse(up, Direction.Up, cellState)
            && WillNeighbourBeValidAfterCollapse(right, Direction.Right, cellState)
            && WillNeighbourBeValidAfterCollapse(down, Direction.Down, cellState)
            && WillNeighbourBeValidAfterCollapse(left, Direction.Left, cellState);
    }

    private bool WillNeighbourBeValidAfterCollapse(Cell? neighbour, Direction neighbourDirection, int originalCellState) => neighbour == null || neighbour.Collapsed
        || !Enumerable.SequenceEqual(neighbour.PossibleStates, Ruleset.DisallowedNeighbours[(originalCellState, neighbourDirection)]);

    private CellWithCoordinates ApplySnapshot(SimulationSnapshot snapshot)
    {
        Grid.ApplyCellSnapshot(snapshot.GridCells);

        // Remove already tried state from cell
        Cell snapshotCell = Grid[snapshot.CellY, snapshot.CellX];
        snapshotCell.RemoveStates(snapshot.CellCollapseState);

        return new(snapshotCell, snapshot.CellX, snapshot.CellY);
    }
}