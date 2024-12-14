using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.FileAccess;

public static class TilesetFileHelper
{
    private static readonly string TilesetsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Tilesets");
    private static readonly string DefaultTilesetsDirectory = Path.Combine(TilesetsDirectory, "Default");

    public static Task<List<Tileset>> LoadNonDefaultTilesetsAsync() => LoadTilesetsAsync(TilesetsDirectory);

    public static Task<List<Tileset>> LoadDefaultTilesetsAsync() => LoadTilesetsAsync(DefaultTilesetsDirectory);

    public static async Task SaveTilesetAsync(Tileset tileset)
    {
        string savePath = Path.Combine(TilesetsDirectory, $"{tileset.Name}.json");

        string jsonData = await Task.Run(() => tileset.ToJson());
        await File.WriteAllTextAsync(savePath, jsonData);
    }

    private static async Task<List<Tileset>> LoadTilesetsAsync(string path)
    {
        string[] tilesetFilePaths = Directory.GetFiles(path, "*.json");
        List<Tileset> tilesets = new(tilesetFilePaths.Length);

        foreach (string tilesetFilePath in tilesetFilePaths)
        {
            string jsonData = await File.ReadAllTextAsync(tilesetFilePath);
            Tileset? tileset = await Task.Run(() => Tileset.FromJson(jsonData));

            if (tileset is null)
                continue;

            tilesets.Add(tileset);
        }

        return tilesets;
    }
}