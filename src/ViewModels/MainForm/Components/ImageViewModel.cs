using System.Drawing.Imaging;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public partial class ImageViewModel : ObservableObject, IImageDisplayer
{
    private readonly ILogger<ImageViewModel> _logger;
    private TileGridImageDrawer? _displayImageDrawer;

    [ObservableProperty]
    private Image _displayImage = new Bitmap(100, 100);
    [ObservableProperty]
    private Size _displayImageSize = new(100, 100);

    private Size _imageGridSize = new(10, 10);

    public ImageViewModel(ITilesetProvider tilesetProvider, ILogger<ImageViewModel> logger)
    {
        _logger = logger;

        tilesetProvider.SelectedTilesetChanged += (s, tileset) =>
        {
            _displayImageDrawer = new(tileset);
            // Redrawing empty grid, but now with proper tile sizes
            DrawEmptyImage();
        };
    }

    [RelayCommand]
    public void SaveImage()
    {
        SaveFileDialog dialog = new()
        {
            AddExtension = true,
            AddToRecent = true,
            Filter = "Png Image|*.png|Bitmap Image|*.bmp|JPeg Image|*.jpg|Gif Image|*.gif",
            Title = "Save an image",
        };

        dialog.ShowDialog();

        if (string.IsNullOrEmpty(dialog.FileName))
            return;

        using FileStream stream = (FileStream)dialog.OpenFile();
        DisplayImage.Save(stream, ImageFormatFromFilterIndex(dialog.FilterIndex));
        _logger.LogInformation("Successfully saved image as {filename}", dialog.FileName);
    }

    public void DisplayGrid(CellGrid grid)
    {
        if (_displayImageDrawer is null)
            return;

        DisplayImage = _displayImageDrawer.DrawTileGrid(grid);
    }

    public void ClearImage() => DrawEmptyImage();

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

    private void DrawEmptyImage()
    {
        if (_displayImageDrawer is null)
            return;

        Image emptyImage = _displayImageDrawer.DrawEmptyImage(_imageGridSize);
        DisplayImage = emptyImage;
        DisplayImageSize = DisplayImage.Size;
    }

    private static ImageFormat ImageFormatFromFilterIndex(int index) => index switch
    {
        1 => ImageFormat.Png,
        2 => ImageFormat.Bmp,
        3 => ImageFormat.Jpeg,
        4 => ImageFormat.Gif,
        _ => throw new InvalidOperationException("Invalid filter index")
    };
}