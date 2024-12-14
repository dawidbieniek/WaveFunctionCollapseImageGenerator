using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public partial class ImageViewModel : ObservableObject, IImageDisplayer
{
    private TileGridImageDrawer? _displayImageDrawer;

    [ObservableProperty]
    private Image _displayImage = new Bitmap(100, 100);
    [ObservableProperty]
    private Size _displayImageSize = new(100, 100);

    private Size _imageGridSize = new(10, 10);

    public ImageViewModel(ITilesetProvider tilesetProvider)
    {
        tilesetProvider.SelectedTilesetChanged += (s, tileset) =>
        {
            _displayImageDrawer = new(tileset);
            // Redrawing empty grid, but now with proper tile sizes
            Image emptyImage = _displayImageDrawer.DrawEmptyImage(_imageGridSize);
            DisplayImage = emptyImage;
            DisplayImageSize = DisplayImage.Size;
        };
    }

    public void DisplayGrid(CellGrid grid)
    {
        if (_displayImageDrawer is null)
            return;

        DisplayImage = _displayImageDrawer.DrawTileGrid(grid);
    }

    public void DisplayGridWithErrorCell(CellGrid grid, int cellX, int cellY)
    {
        if (_displayImageDrawer is null)
            return;

        DisplayImage = _displayImageDrawer.DrawTileGridWithInvalidCellIndicator(grid, cellX, cellY);
    }

    public void ChangeImageSize(Size newSize)
    {
        _imageGridSize = newSize;
        Image emptyImage = _displayImageDrawer?.DrawEmptyImage(newSize) ?? TileGridImageDrawer.DrawEmptyImageWithoutTileset(newSize);

        DisplayImage = emptyImage;
        DisplayImageSize = DisplayImage.Size;
    }
}