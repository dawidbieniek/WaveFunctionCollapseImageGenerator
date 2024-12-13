namespace WaveFunctionCollapseImageGenerator.Models.Cells;

/// <summary>
/// Container for <see cref="Cell"/> s. Indexing starts from upper left corner
/// </summary>
public class CellGrid
{
    private readonly bool _edgeWrapping;
    private readonly Random _random;

    private Cell[,] _cells;

    public CellGrid(int width, int height, bool edgeWrapping, IList<int> possibleCellStates, Random random)
    {
        _edgeWrapping = edgeWrapping;
        _random = random;

        Width = width;
        Height = height;

        _cells = new Cell[height, width];

        for (int i = 0; i < height; i++)
            for (int j = 0; j < width; j++)
            {
                _cells[i, j] = new([.. possibleCellStates], _random);
            }
    }

    public int Width { get; private init; }
    public int Height { get; private init; }
    public bool AreAllCellsCollapsed => !_cells.Cast<Cell>().Any(c => !c.Collapsed);

    public Cell this[int y, int x] => _cells[y, x];

    public (Cell? up, Cell? right, Cell? down, Cell? left) GetNeighboursOfCell(int x, int y)
    {
        if (x < 0 || y < 0 || x >= Width || y >= Height)
            throw new ArgumentException($"Incorrect cell coordinates (y:{y}, x:{x})");

        int leftIndex = _edgeWrapping ? (x - 1 + Width) % Width : x - 1;
        int rightIndex = _edgeWrapping ? (x + 1) % Width : x + 1;
        int upIndex = _edgeWrapping ? (y - 1 + Height) % Height : y - 1;
        int downIndex = _edgeWrapping ? (y + 1) % Height : y + 1;

        return
        (
            upIndex >= 0 ? _cells[upIndex, x] : null,
            rightIndex < Width ? _cells[y, rightIndex] : null,
            downIndex < Height ? _cells[downIndex, x] : null,
            leftIndex >= 0 ? _cells[y, leftIndex] : null
        );
    }

    public IList<CellWithCoordinates> GetLowestEntropyCollapsableCellsWithCoordinates()
    {
        int minEntropy = _cells.Cast<Cell>()
            .Where(c => !c.Collapsed)
            .Min(cell => cell.Entropy);

        List<CellWithCoordinates> minEntropyCellCoords = [];

        for (int i = 0; i < _cells.GetLength(0); i++)
            for (int j = 0; j < _cells.GetLength(1); j++)
            {
                if (_cells[i, j].Entropy == minEntropy && !_cells[i, j].Collapsed)
                    minEntropyCellCoords.Add(new(_cells[i, j], j, i));
            }

        return minEntropyCellCoords;
    }

    /// <summary>
    /// Creates clone of all <see cref="Cell"/> s
    /// </summary>
    public Cell[,] CreateCellSnapshot()
    {
        Cell[,] clonedCells = new Cell[Height, Width];

        for (int i = 0; i < Height; i++)
            for (int j = 0; j < Width; j++)
            {
                clonedCells[i, j] = new(this[i, j]);
            }

        return clonedCells;
    }

    /// <summary>
    /// Uses previously created clone of <see cref="Cell"/> s ( <see cref="CreateCellSnapshot"/>) to
    /// apply previous state
    /// </summary>
    /// <param name="cells"> </param>
    public void ApplyCellSnapshot(Cell[,] cells) => _cells = cells;
}