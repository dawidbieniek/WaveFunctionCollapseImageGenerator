using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

public interface ITilesetProvider
{
    Tileset Tileset { get; }
}