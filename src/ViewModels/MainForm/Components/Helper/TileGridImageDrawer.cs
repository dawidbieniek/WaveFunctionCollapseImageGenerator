using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components.Helper;

public class TileGridImageDrawer
{
    private static readonly Color UncollapsedCellColor = Color.Gray;
    private static readonly Pen InvalidCellPen = new(Color.Red, 2);

    private readonly Bitmap _uncollapsedCellImage;

    private readonly Tileset _tileSet;

    public TileGridImageDrawer(Tileset tileset)
    {
        _tileSet = tileset;
        CellSize = new(_tileSet.Images[0].Width, _tileSet.Images[0].Height);

        _uncollapsedCellImage = new(CellSize.Width, CellSize.Height);
        using Graphics g = Graphics.FromImage(_uncollapsedCellImage);
        g.Clear(UncollapsedCellColor);
    }

    public Size CellSize { get; }

    public Image DrawTileGrid(CellGrid grid)
    {
        Bitmap bitmap = new(CellSize.Width * grid.Width, CellSize.Height * grid.Height);

        using Graphics g = Graphics.FromImage(bitmap);
        for (int i = 0; i < grid.Height; i++)
            for (int j = 0; j < grid.Width; j++)
            {
                Bitmap cellImage = grid[i, j].CurrentState is null
                    ? _uncollapsedCellImage
                    : _tileSet.ImageFromTileIndex(grid[i, j].CurrentState!.Value);

                g.DrawImage(cellImage, new Point(j * CellSize.Width, i * CellSize.Height));
            }

        return bitmap;
    }

    public Image DrawEmptyImage(Size gridSize)
    {
        Bitmap bitmap = new(CellSize.Width * gridSize.Width, CellSize.Height * gridSize.Height);
        using Graphics g = Graphics.FromImage(bitmap);
        g.Clear(UncollapsedCellColor);
        return bitmap;
    }

    public Image DrawTileGridWithInvalidCellIndicator(CellGrid grid, int cellX, int cellY)
    {
        Image image = DrawTileGrid(grid);

        using Graphics g = Graphics.FromImage(image);
        g.DrawRectangle(InvalidCellPen, cellX * CellSize.Width, cellY * CellSize.Height, CellSize.Width, CellSize.Height);

        return image;
    }
}