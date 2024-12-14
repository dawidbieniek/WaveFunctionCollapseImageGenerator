using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public interface IGridProvider
{
    CellGrid? CreateGrid(Random random);

    void LockChanges();

    void UnlockChanges();
}