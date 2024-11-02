using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public interface ITilesetProvider
{
    Tileset Tileset { get; }
}