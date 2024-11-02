namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

/// <summary>
/// Container for array representing <see cref="Tile"/> edge
/// </summary>
/// <remarks> <see cref="EdgeFragments"/> are in clockwise order </remarks>
public class TileEdge(params int[] edgeFragments) : ITransformable
{
    public int[] EdgeFragments { get; private set; } = edgeFragments;

    public ITransformable Reverse()
    {
        EdgeFragments = [.. EdgeFragments.Reverse()];
        return this;
    }
}