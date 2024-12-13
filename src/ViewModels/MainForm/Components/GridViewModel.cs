using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class GridViewModel : ObservableObject, IGridProvider
{
    private readonly ITilesetProvider _tilesetProvider;

    private readonly IImageDisplayer _imageDisplayer;

    [ObservableProperty]
    private int _width = 10;
    [ObservableProperty]
    private int _height = 10;
    [ObservableProperty]
    private bool _useEdgeWrapping = false;
    [ObservableProperty]
    private bool _allowEditing = true;

    public GridViewModel(ITilesetProvider tilesetProvider, IImageDisplayer imageDisplayer)
    {
        _tilesetProvider = tilesetProvider;
        _imageDisplayer = imageDisplayer;

        _imageDisplayer.ChangeImageSize(new(Width, Height));
    }

    public CellGrid CreateGrid(Random random) => new(Width, Height, UseEdgeWrapping, [.. Enumerable.Range(0, _tilesetProvider.Tileset.TileCount)], random);

    public void LockChanges() => AllowEditing = false;

    public void UnlockChanges() => AllowEditing = true;

    partial void OnWidthChanged(int value) => _imageDisplayer.ChangeImageSize(new(Width, Height));

    partial void OnHeightChanged(int value) => _imageDisplayer.ChangeImageSize(new(Width, Height));
}