using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using WaveFunctionCollapseImageGenerator.Models.FileAccess;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public partial class TilesetViewModel : ObservableObject, ITilesetProvider
{
    [ObservableProperty]
    private ObservableCollection<Tileset> _availableTilesets = [];

    public async Task InitializeAsync()
    {
        List<Tileset> tilesets = await TilesetFileHelper.LoadDefaultTilesetsAsync();
        tilesets.AddRange(await TilesetFileHelper.LoadNonDefaultTilesetsAsync());

        AvailableTilesets = [.. tilesets];

        if (AvailableTilesets.Count == 0)
            throw new InvalidOperationException("Cannot load any tilesets");

        SelectedTileset = AvailableTilesets[0];
    }

    [ObservableProperty]
    private Tileset _selectedTileset = null!;

    public event EventHandler<Tileset> SelectedTilesetChanged = delegate { };

    public Tileset? Tileset => AvailableTilesets.Count >= 0 ? (SelectedTileset ??= AvailableTilesets[0]) : null;

    partial void OnSelectedTilesetChanged(Tileset value) => SelectedTilesetChanged.Invoke(this, value);
}