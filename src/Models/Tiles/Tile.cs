using WaveFunctionCollapseImageGenerator.Models.Common;

namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

public record Tile(int ImageIndex, TileEdge UpEdge, TileEdge RightEdge, TileEdge DownEdge, TileEdge LeftEdge)
{
    /// <summary>
    /// Creates new <see cref="Tile"/> with edge order modified based on <paramref name="transform"/>
    /// </summary>
    /// <returns> New <see cref="Tile"/> instance </returns>
    public static Tile CreateWithTransform(int imageIndex, TileEdge upEdge, TileEdge rightEdge, TileEdge downEdge, TileEdge leftEdge, Transform transform)
    {
        var (up, right, down, left) = transform.TransformItems(upEdge, rightEdge, downEdge, leftEdge);
        return new(imageIndex, up, right, down, left);
    }

    public bool FitsWith(Tile other, Direction direction)
    {
        int[] otherEdge = [.. other.EdgeAt(direction.Opposite()).EdgeFragments.Reverse()];
        return Enumerable.SequenceEqual(EdgeAt(direction).EdgeFragments, otherEdge);
    }

    private TileEdge EdgeAt(Direction direction)
    {
        return direction switch
        {
            Direction.Up => UpEdge,
            Direction.Right => RightEdge,
            Direction.Down => DownEdge,
            Direction.Left => LeftEdge,
            _ => throw new ArgumentException($"Invalid direction ({direction})"),
        };
    }
}