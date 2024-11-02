namespace WaveFunctionCollapseImageGenerator.Models.Cells;

//TODO: Probably shoule use factory instead
public class CellGridBuilder(int width, int height, IList<int> possibleCellStates)
{
    private readonly int _gridWidth = width;
    private readonly int _gridHeight = height;

    private bool _edgeWrapping = false;

    public CellGridBuilder WithEdgeWrapping()
    {
        _edgeWrapping = true;
        return this;
    }

    public CellGridBuilder WithBacktracking()
    {
        return this;
    }

    public CellGrid Build()
    {
        return new CellGrid(_gridWidth, _gridHeight, _edgeWrapping, possibleCellStates);
    }
}