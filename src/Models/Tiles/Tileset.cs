namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

public record Tileset(Bitmap[] Images, Tile[] Tiles, Ruleset Ruleset)
{
    public int TileCount => Tiles.Length;

    public Bitmap ImageFromTileIndex(int tileIndex)
    {
        return tileIndex < 0 || tileIndex >= Tiles.Length
            ? throw new ArgumentException($"Incorrect tile index ({tileIndex})")
            : Images[Tiles[tileIndex].ImageIndex];
    }
}