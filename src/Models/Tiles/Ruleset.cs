using WaveFunctionCollapseImageGenerator.Models.Common;

namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

[Serializable]
public record Ruleset(Dictionary<(int state, Direction dir), int[]> DisallowedNeighbours)
{
    public static Ruleset FromTileList(IList<Tile> tiles)
    {
        Dictionary<(int state, Direction dir), int[]> rulesetMap = [];

        IEnumerable<Direction> dirs = Enum.GetValues<Direction>();

        foreach (Tile tile in tiles)
        {
            foreach (Direction dir in dirs)
            {
                List<int> disallowedNeigbours = [];

                foreach (Tile other in tiles)
                {
                    if (!tile.FitsWith(other, dir))
                        disallowedNeigbours.Add(other.ImageIndex);
                }

                rulesetMap.Add((tile.ImageIndex, dir), [.. disallowedNeigbours]);
            }
        }

        return new(rulesetMap);
    }
}