using System.Text.Json;
using System.Text.Json.Serialization;

using WaveFunctionCollapseImageGenerator.Models.Common;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Common.JsonConverters;

public class RulesetConverter : JsonConverter<Ruleset>
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(Ruleset);

    public override Ruleset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        Dictionary<(int state, Direction dir), int[]>? disallowedNeighbours = null;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException("Expected property name");

            string propertyName = reader.GetString()!;
            reader.Read(); // Move past property name

#pragma warning disable IDE0066 // Convert switch statement to expression
            switch (propertyName)
            {
                case nameof(Ruleset.DisallowedNeighbours):
                    disallowedNeighbours = ReadDisallowedNeighbours(ref reader, options);
                    break;

                default:
                    throw new JsonException();
            }
#pragma warning restore IDE0066 // Convert switch statement to expression
        }

        return disallowedNeighbours is null
            ? throw new JsonException()
            : new(disallowedNeighbours);
    }

    public override void Write(Utf8JsonWriter writer, Ruleset value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WritePropertyName(nameof(Ruleset.DisallowedNeighbours));

        writer.WriteStartObject();
        foreach (KeyValuePair<(int state, Direction dir), int[]> rule in value.DisallowedNeighbours)
        {
            writer.WritePropertyName(rule.Key.ToString());
            JsonSerializer.Serialize(writer, rule.Value, options);
        }
        writer.WriteEndObject();

        writer.WriteEndObject();
    }

    private Dictionary<(int state, Direction dir), int[]> ReadDisallowedNeighbours(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        Dictionary<(int state, Direction dir), int[]> disallowedNeighbours = [];

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;

            (int, Direction) key = ReadKeyTuple(ref reader);

            int[] neighbourArray = JsonSerializer.Deserialize<int[]>(ref reader, options)!;
            disallowedNeighbours.Add(key, neighbourArray);
        }

        return disallowedNeighbours;
    }

    private static (int, Direction) ReadKeyTuple(ref Utf8JsonReader reader)
    {
        string keyJson = reader.GetString() ?? throw new JsonException();
        string[] parts = keyJson[1..^1].Split(", ");

        return (int.Parse(parts[0]), Enum.Parse<Direction>(parts[1]));
    }
}