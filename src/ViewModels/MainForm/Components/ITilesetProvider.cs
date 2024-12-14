using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public interface ITilesetProvider
{
    event EventHandler<Tileset> SelectedTilesetChanged;
    Tileset? Tileset { get; }
}