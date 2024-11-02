using WaveFunctionCollapseImageGenerator.Models.Common;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Test.Models;

[TestClass]
public class TileTest
{
    public static IEnumerable<(Tile first, Tile other, bool up, bool right, bool down, bool left)> FitsWith_ChecksEdgeCorrectly_Data =>
    [
        (new Tile(-1, new(0), new(0), new(0), new(0)), new Tile(-1, new(0), new(0), new(0), new(0)), true, true, true, true),
        (new Tile(-1, new(0), new(0), new(1), new(1)), new Tile(-1, new(1), new(1), new(0), new(1)), true, false, true, true),
        (new Tile(-1, new(1, 0), new(1, 0), new(1, 0), new(1, 0)), new Tile(-1, new(1, 0), new(1, 0), new(1, 0), new(1, 0)), false, false, false, false),
        (new Tile(-1, new(0, 1), new(1, 0), new(1, 0), new(1, 0)), new Tile(-1, new(1, 0), new(1, 0), new(1, 0), new(1, 0)), true, false, false, false),
    ];

    [TestMethod]
    [DynamicData(nameof(FitsWith_ChecksEdgeCorrectly_Data))]
    public void FitsWith_ChecksEdgeCorrectly(Tile first, Tile other, bool up, bool right, bool down, bool left)
    {
        Assert.AreEqual(up, first.FitsWith(other, Direction.Up), $"(Up) first: {string.Join(", ", first.UpEdge.EdgeFragments)} other: {string.Join(", ", other.DownEdge.EdgeFragments)}");
        Assert.AreEqual(right, first.FitsWith(other, Direction.Right), $"(Right) first: {string.Join(", ", first.RightEdge.EdgeFragments)} other: {string.Join(", ", other.LeftEdge.EdgeFragments)}");
        Assert.AreEqual(down, first.FitsWith(other, Direction.Down), $"(Down) first: {string.Join(", ", first.DownEdge.EdgeFragments)} other: {string.Join(", ", other.UpEdge.EdgeFragments)}");
        Assert.AreEqual(left, first.FitsWith(other, Direction.Left), $"(Left) first: {string.Join(", ", first.LeftEdge.EdgeFragments)} other: {string.Join(", ", other.RightEdge.EdgeFragments)}");
    }
}