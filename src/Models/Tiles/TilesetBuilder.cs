namespace WaveFunctionCollapseImageGenerator.Models.Tiles;

public class TilesetBuilder
{
    private List<Bitmap> _images = [];
    private List<Tile> _tiles = [];
    private bool _buildRuleset = false;

    public TilesetBuilder WithTile(Bitmap image, TileEdge upEdge, TileEdge rightEdge, TileEdge downEdge, TileEdge leftEdge, params IEnumerable<Transform> availableTransforms)
    {
        if (!availableTransforms.Any())
        {
            int imageIndex = _images.Count;
            _images.Add(image);

            _tiles.Add(new(imageIndex, upEdge, rightEdge, downEdge, leftEdge));
        }
        else
        {
            foreach (Transform transform in availableTransforms)
            {
                Bitmap transformedImage = transform.TransformedImage(image);
                int imageIndex = _images.Count;
                _images.Add(transformedImage);

                _tiles.Add(Tile.CreateWithTransform(imageIndex, upEdge, rightEdge, downEdge, leftEdge, transform));
            }
        }

        return this;
    }

    public TilesetBuilder WithRuleset()
    {
        _buildRuleset = true;
        return this;
    }

    public Tileset Build()
    {
        Ruleset ruleset = new([]);

        if (_buildRuleset)
            ruleset = Ruleset.FromTileList(_tiles);

        return new([.. _images], [.. _tiles], ruleset);
    }
}