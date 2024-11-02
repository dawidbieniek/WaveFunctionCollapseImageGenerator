using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public partial class GridViewModel : ObservableObject, IGridProvider
{
    private readonly ITilesetProvider _tilesetProvider;

    private CellGrid _grid;

    [ObservableProperty]
    private int _width = 20;
    [ObservableProperty]
    private int _height = 20;
    [ObservableProperty]
    private bool _useBacktracking = false;
    [ObservableProperty]
    private bool _useEdgeWrapping = false;

    public GridViewModel(ITilesetProvider tilesetProvider)
    {
        _tilesetProvider = tilesetProvider;

        _grid = new CellGridBuilder(Width, Height, [.. Enumerable.Range(0, _tilesetProvider.Tileset.TileCount)]).Build();
    }

    public CellGrid Grid => _grid;
}