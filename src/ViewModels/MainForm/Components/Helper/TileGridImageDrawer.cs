using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

public class TileGridImageDrawer
{
    private static readonly Color UncollapsedCellColor = Color.Gray;
    private static readonly Pen InvalidCellPen = new(Color.Red, 2);

    private readonly Bitmap _uncollapsedCellImage;

    private readonly Tileset _tileSet;
    private readonly Size _cellSize;

    public TileGridImageDrawer(Tileset tileset)
    {
        _tileSet = tileset;
        _cellSize = new(_tileSet.Images[0].Width, _tileSet.Images[0].Height);

        _uncollapsedCellImage = new(_cellSize.Width, _cellSize.Height);
        using Graphics g = Graphics.FromImage(_uncollapsedCellImage);
        g.Clear(UncollapsedCellColor);
    }

    public Image DrawTileGrid(CellGrid grid)
    {
        Bitmap bitmap = new(_cellSize.Width * grid.Width, _cellSize.Height * grid.Height);

        using Graphics g = Graphics.FromImage(bitmap);
        for (int i = 0; i < grid.Height; i++)
            for (int j = 0; j < grid.Width; j++)
            {
                Bitmap cellImage = grid[i, j].CurrentState is null
                    ? _uncollapsedCellImage
                    : _tileSet.ImageFromTileIndex(grid[i, j].CurrentState!.Value);

                g.DrawImage(cellImage, new Point(j * _cellSize.Width, i * _cellSize.Height));
            }

        return bitmap;
    }

    public Image DrawTileGridWithInvalidCellIndicator(CellGrid grid, int cellX, int cellY)
    {
        Image image = DrawTileGrid(grid);

        using Graphics g = Graphics.FromImage(image);
        g.DrawRectangle(InvalidCellPen, cellX * _cellSize.Width, cellY * _cellSize.Height, _cellSize.Width, _cellSize.Height);

        return image;
    }
}