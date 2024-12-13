using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public partial class ImageViewModel : ObservableObject, IImageDisplayer
{
    private readonly ITilesetProvider _tilesetProvider;
    private readonly TileGridImageDrawer _displayImageDrawer;

    [ObservableProperty]
    private Image _displayImage = new Bitmap(100, 100);
    [ObservableProperty]
    private Size _displayImageSize = new(100, 100);

    public ImageViewModel(ITilesetProvider tilesetProvider)
    {
        _tilesetProvider = tilesetProvider;

        _displayImageDrawer = new(_tilesetProvider.Tileset);
    }

    public void DisplayGrid(CellGrid grid) => DisplayImage = _displayImageDrawer.DrawTileGrid(grid);

    public void DisplayGridWithErrorCell(CellGrid grid, int cellX, int cellY) => DisplayImage = _displayImageDrawer.DrawTileGridWithInvalidCellIndicator(grid, cellX, cellY);

    public void ChangeImageSize(Size newSize)
    {
        Image emptyImage = _displayImageDrawer.DrawEmptyImage(newSize);

        DisplayImageSize = DisplayImage.Size;
        DisplayImage = emptyImage;
    }
}