using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Common;
using WaveFunctionCollapseImageGenerator.Models.Exceptions;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation;

public class WaveFunctionCollapseSimulation(CellGrid grid, Ruleset ruleset, Random random) : IWFCSimulation
{
    protected CellGrid Grid { get; private init; } = grid;
    protected Ruleset Ruleset { get; private init; } = ruleset;
    protected Random Random { get; private init; } = random;

    // Possible improvements:
    // TODO: Separate collection for lowest entropy cells - store instead of iterate
    public virtual void Step()
    {
        IList<CellWithCoordinates> potentialCells = Grid.GetLowestEntropyCollapsableCellsWithCoordinates();
        CellWithCoordinates cell = potentialCells[Random.Next(potentialCells.Count)];

        try
        {
            int cellState = cell.Cell.Collapse();
            UpdateNeighbours(cell.X, cell.Y, cellState);
        }
        catch (InvalidOperationException ex)
        {
            throw new InvalidCellCollapseException(cell, ex.Message);
        }
    }

    protected void UpdateNeighbours(int x, int y, int cellState)
    {
        (Cell? up, Cell? right, Cell? down, Cell? left) = Grid.GetNeighboursOfCell(x, y);
        UpdateNeighbour(up, Direction.Up, cellState);
        UpdateNeighbour(right, Direction.Right, cellState);
        UpdateNeighbour(down, Direction.Down, cellState);
        UpdateNeighbour(left, Direction.Left, cellState);
    }

    private void UpdateNeighbour(Cell? neighbour, Direction neighbourDirection, int originalCellState)
    {
        if (neighbour == null || neighbour.Collapsed)
            return;

        neighbour.RemoveStates(Ruleset.DisallowedNeighbours[(originalCellState, neighbourDirection)]);
    }
}