namespace WaveFunctionCollapseImageGenerator.Models.Cells;

/// <summary>
/// Container for <see cref="Cell"/> s. Indexing starts from upper left corner
/// </summary>
public class CellGrid
{
    private Cell[,] _cells;
    private bool _edgeWrapping;

    public CellGrid(int width, int height, bool edgeWrapping, IList<int> possibleCellStates)
    {
        _edgeWrapping = edgeWrapping;
        Width = width;
        Height = height;

        _cells = new Cell[height, width];

        for (int i = 0; i < Height; i++)
            for (int j = 0; j < Width; j++)
            {
                _cells[i, j] = new([.. possibleCellStates], new());
            }
    }

    public int Width { get; private init; }
    public int Height { get; private init; }

    public Cell this[int y, int x] => _cells[y, x];

    public (Cell? up, Cell? right, Cell? down, Cell? left) GetNeighboursOfCell(int x, int y)
    {
        if (x < 0 || y < 0 || x >= Width || y >= Height)
            throw new ArgumentException($"Incorrect cell coordinates (y:{y}, x:{x})");

        int leftIndex = _edgeWrapping ? (x - 1 + Width) % Width : x - 1;
        int rightIndex = _edgeWrapping ? (x + 1) % Width : x + 1;
        int upIndex = _edgeWrapping ? (y - 1 + Height) % Height : y - 1;
        int downIndex = _edgeWrapping ? (y + 1) % Height : y + 1;

        return (
            upIndex >= 0 ? _cells[upIndex, x] : null,
            rightIndex < Width ? _cells[y, rightIndex] : null,
            downIndex < Height ? _cells[downIndex, x] : null,
            leftIndex >= 0 ? _cells[y, leftIndex] : null
        );
    }

    public IList<(Cell cell, int x, int y)> GetLowestEntropyCollapsableCellsWithCoordinates()
    {
        int minEntropy = _cells.Cast<Cell>().Where(c => !c.Collapsed).Min(cell => cell.Entropy);
        List<(Cell cell, int x, int y)> minEntropyCellCoords = [];

        for (int i = 0; i < _cells.GetLength(0); i++)
            for (int j = 0; j < _cells.GetLength(1); j++)
            {
                if (_cells[i, j].Entropy == minEntropy && !_cells[i, j].Collapsed)
                    minEntropyCellCoords.Add((_cells[i, j], j, i));
            }

        return minEntropyCellCoords;
    }
}