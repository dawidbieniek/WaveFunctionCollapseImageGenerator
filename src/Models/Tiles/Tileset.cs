using System.Text.Json;
using System.Text.Json.Serialization;

using WaveFunctionCollapseImageGenerator.Common.JsonConverters;

namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

public record Tileset(Bitmap[] Images, Tile[] Tiles, Ruleset Ruleset, string Name)
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new RulesetConverter(),
            new BitmapBase64Converter()
        }
    };

    [JsonIgnore]
    public int TileCount => Tiles.Length;

    public Bitmap ImageFromTileIndex(int tileIndex)
    {
        return tileIndex < 0 || tileIndex >= Tiles.Length
            ? throw new ArgumentException($"Incorrect tile index ({tileIndex})")
            : Images[Tiles[tileIndex].ImageIndex];
    }

    public string ToJson() => JsonSerializer.Serialize(this, SerializerOptions);

    public static Tileset? FromJson(string jsonString) => JsonSerializer.Deserialize<Tileset>(jsonString, SerializerOptions);
}