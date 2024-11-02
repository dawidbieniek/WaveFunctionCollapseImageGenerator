using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public interface IGridProvider
{
    CellGrid? Grid { get; }

    CellGrid CreateGrid(Random random);

    void LockChanges();

    void UnlockChanges();
}