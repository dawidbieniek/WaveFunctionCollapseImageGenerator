using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public interface IGridProvider
{
    CellGrid Grid { get; }
}