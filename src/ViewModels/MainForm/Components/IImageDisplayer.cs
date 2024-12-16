using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;
public interface IImageDisplayer
{
    void DisplayGrid(CellGrid grid);
    void ClearImage();
    void DisplayGridWithErrorCell(CellGrid grid, int cellX, int cellY);
    void ChangeImageSize(Size newSize);
}
