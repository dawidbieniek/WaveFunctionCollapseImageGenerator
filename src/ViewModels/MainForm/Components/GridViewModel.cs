using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class GridViewModel(ITilesetProvider tilesetProvider) : ObservableObject, IGridProvider
{
    private readonly ITilesetProvider _tilesetProvider = tilesetProvider;

    [ObservableProperty]
    private int _width = 20;
    [ObservableProperty]
    private int _height = 20;
    [ObservableProperty]
    private bool _useEdgeWrapping = false;
    [ObservableProperty]
    private bool _allowEditing = true;

    public CellGrid? Grid { get; private set; }

    public CellGrid CreateGrid(Random random) => Grid = new(Width, Height, UseEdgeWrapping, [.. Enumerable.Range(0, _tilesetProvider.Tileset.TileCount)], random);

    public void LockChanges() => AllowEditing = false;

    public void UnlockChanges() => AllowEditing = true;
}