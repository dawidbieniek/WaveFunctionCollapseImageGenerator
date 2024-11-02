using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

public class Tileset
{
    public Bitmap[] Images = [];
    public Tile[] Tiles = [];
    public Ruleset Ruleset = new();

    public int TileCount => Tiles.Length;

    public Bitmap ImageFromTileIndex(int tileIndex)
    {
        if (tileIndex < 0 || tileIndex >= Tiles.Length)
            throw new ArgumentException($"Incorrect tile index ({tileIndex})");

        return Images[Tiles[tileIndex].ImageIndex];
    }
}