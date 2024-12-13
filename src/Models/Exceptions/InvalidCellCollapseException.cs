using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Models.Exceptions;

[Serializable]
public class InvalidCellCollapseException : Exception
{
    public InvalidCellCollapseException(CellWithCoordinates cell)
    {
        InvalidCell = cell;
    }

    public InvalidCellCollapseException(CellWithCoordinates cell, string message) : base(message)
    {
        InvalidCell = cell;
    }

    public InvalidCellCollapseException(CellWithCoordinates cell, string message, Exception inner) : base(message, inner)
    {
        InvalidCell = cell;
    }

    public CellWithCoordinates InvalidCell { get; private init; }
}