using System.Drawing.Imaging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WaveFunctionCollapseImageGenerator.Common.JsonConverters;

public class BitmapBase64Converter : JsonConverter<Bitmap>
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(Bitmap);
    }

    public override Bitmap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string base64Text = reader.GetString() ?? throw new JsonException();
        byte[] imageData = Convert.FromBase64String(base64Text);
        using MemoryStream ms = new(imageData);
        return new Bitmap(ms);
    }

    public override void Write(Utf8JsonWriter writer, Bitmap value, JsonSerializerOptions options)
    {
        using MemoryStream ms = new();
        value.Save(ms, ImageFormat.Png);
        byte[] imageData = ms.ToArray();
        writer.WriteBase64StringValue(imageData);
    }
}