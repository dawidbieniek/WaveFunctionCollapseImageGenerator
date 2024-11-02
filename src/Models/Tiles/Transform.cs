namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1069:Enums values should not be duplicated", Justification = "Some transforms have the same effect as others")]
public enum Transform
{
    RotateNoneFlipNone = RotateFlipType.RotateNoneFlipNone,
    Rotate90FlipNone = RotateFlipType.Rotate90FlipNone,
    Rotate180FlipNone = RotateFlipType.Rotate180FlipNone,
    Rotate270FlipNone = RotateFlipType.Rotate270FlipNone,
    RotateNoneFlipX = RotateFlipType.RotateNoneFlipX,
    Rotate90FlipX = RotateFlipType.Rotate90FlipX,
    Rotate180FlipX = RotateFlipType.Rotate180FlipX,
    Rotate270FlipX = RotateFlipType.Rotate270FlipX,
    RotateNoneFlipY = RotateFlipType.RotateNoneFlipY,
    Rotate90FlipY = RotateFlipType.Rotate90FlipY,
    Rotate180FlipY = RotateFlipType.Rotate180FlipY,
    Rotate270FlipY = RotateFlipType.Rotate270FlipY,
    RotateNoneFlipXY = RotateFlipType.RotateNoneFlipXY,
    Rotate90FlipXY = RotateFlipType.Rotate90FlipXY,
    Rotate180FlipXY = RotateFlipType.Rotate180FlipXY,
    Rotate270FlipXY = RotateFlipType.Rotate270FlipXY,
}

public static class TransformExtensions
{
    public static (T up, T right, T down, T left) TransformItems<T>(this Transform transform, T up, T right, T down, T left) where T : ITransformable
    {
        return transform switch
        {
            Transform.RotateNoneFlipNone => (up, right, down, left),
            Transform.Rotate90FlipNone => (left, up, right, down),
            Transform.Rotate180FlipNone => (down, left, up, right),
            Transform.Rotate270FlipNone => (right, down, left, up),
            Transform.RotateNoneFlipX => ((T)down.Reverse(), (T)right.Reverse(), (T)up.Reverse(), (T)left.Reverse()),
            Transform.Rotate180FlipX => ((T)up.Reverse(), (T)left.Reverse(), (T)down.Reverse(), (T)right.Reverse()),

            Transform.Rotate270FlipX => ((T)left.Reverse(), (T)down.Reverse(), (T)right.Reverse(), (T)up.Reverse()),
            Transform.Rotate90FlipX => ((T)right.Reverse(), (T)up.Reverse(), (T)left.Reverse(), (T)down.Reverse()),
            _ => throw new ArgumentException($"Incorrect {nameof(RotateFlipType)} value ({(int)transform})"),
        };
    }

    /// <summary>
    /// Creates new <see cref="Bitmap"/> based on <paramref name="transform"/>
    /// </summary>
    public static Bitmap TransformedImage(this Transform transform, Bitmap bitmap)
    {
        Bitmap transformed = (Bitmap)bitmap.Clone();
        transformed.RotateFlip((RotateFlipType)transform);
        return transformed;
    }
}