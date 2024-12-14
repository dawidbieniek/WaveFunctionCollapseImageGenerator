using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.FileAccess;

/// <summary>
/// This is class for manually creating default tilesets. It shouldn't be used in runtime
/// </summary>
internal static class DebugTilesetCreator
{
    private static readonly string TileImagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Assets");

    public static async Task CreateDefaultTilesets()
    {
        await CreateRectanglesTileset();
        await CreateLinesTileset();
        await CreateCircularShapesTileset();
        await CreateCirclesTileset();
        await CreatePipesTileset();
        await CreateCircuitTileset();
        await CreateRailsTileset();
    }

    public static async Task CreateRectanglesTileset()
    {
        TilesetBuilder builder = new();

        Bitmap blank = new(20, 20);
        using (Graphics g = Graphics.FromImage(blank))
        {
            g.Clear(Color.White);
        }
        Bitmap redCorner = new(20, 20);
        using (Graphics g = Graphics.FromImage(redCorner))
        {
            g.Clear(Color.White);
            g.FillRectangle(new SolidBrush(Color.Red), new(0, 0, 10, 10));
        }
        Bitmap blueCorner = new(20, 20);
        using (Graphics g = Graphics.FromImage(blueCorner))
        {
            g.Clear(Color.White);
            g.FillRectangle(new SolidBrush(Color.Blue), new(0, 0, 10, 10));
        }
        Bitmap redAndBlueDoubleCorner = new(20, 20);
        using (Graphics g = Graphics.FromImage(redAndBlueDoubleCorner))
        {
            g.Clear(Color.White);
            g.FillRectangle(new SolidBrush(Color.Red), new(0, 0, 10, 10));
            g.FillRectangle(new SolidBrush(Color.Blue), new(10, 10, 10, 10));
        }

        builder
            .WithTile(blank, new([0]), new([0]), new([0]), new([0]))
            .WithTile(redCorner, new([1, 0]), new([0]), new([0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            .WithTile(blueCorner, new([2, 0]), new([0]), new([0]), new([0, 2]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            .WithTile(redAndBlueDoubleCorner, new([1, 0]), new([0, 2]), new([2, 0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            .WithRuleset()
            .WithName("Rectangles");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreateLinesTileset()
    {
        TilesetBuilder builder = new();

        Brush brush = new SolidBrush(Color.Blue);
        Brush lineEndBrush = new SolidBrush(Color.Red);

        Bitmap blank = new(20, 20);
        using (Graphics g = Graphics.FromImage(blank))
        {
            g.Clear(Color.Beige);
        }
        Bitmap longI = new(20, 20);
        using (Graphics g = Graphics.FromImage(longI))
        {
            g.Clear(Color.Beige);
            g.FillRectangle(brush, 8, 0, 4, 20);
        }
        Bitmap shortI = new(20, 20);
        using (Graphics g = Graphics.FromImage(shortI))
        {
            g.Clear(Color.Beige);
            g.FillRectangle(brush, 8, 0, 4, 10);
            g.FillEllipse(lineEndBrush, 8, 8, 4, 4);
        }
        Bitmap t = new(20, 20);
        using (Graphics g = Graphics.FromImage(t))
        {
            g.Clear(Color.Beige);
            g.FillRectangle(brush, 8, 0, 4, 20);
            g.FillRectangle(brush, 8, 8, 12, 4);
        }
        Bitmap l = new(20, 20);
        using (Graphics g = Graphics.FromImage(l))
        {
            g.Clear(Color.Beige);
            g.FillRectangle(brush, 8, 0, 4, 10);
            g.FillRectangle(brush, 8, 8, 12, 4);
        }
        Bitmap x = new(20, 20);
        using (Graphics g = Graphics.FromImage(x))
        {
            g.Clear(Color.Beige);
            g.FillRectangle(brush, 8, 0, 4, 20);
            g.FillRectangle(brush, 0, 8, 20, 4);
        }

        builder
            .WithTile(blank, new([0]), new([0]), new([0]), new([0]))
            .WithTile(longI, new([1]), new([0]), new([1]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(shortI, new([1]), new([0]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(t, new([1]), new([1]), new([1]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(l, new([1]), new([1]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(x, new([1]), new([1]), new([1]), new([1]))
            .WithRuleset()
            .WithName("Lines");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreateCircularShapesTileset()
    {
        TilesetBuilder builder = new();

        Bitmap black = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "Black.png"));
        Bitmap blackDouble = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackDouble.png"));
        Bitmap blackHalf = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackHalf.png"));
        Bitmap blackQuarter = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackQuarter.png"));
        Bitmap white = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "White.png"));
        Bitmap whiteDouble = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteDouble.png"));
        Bitmap whiteHalf = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteHalf.png"));
        Bitmap whiteQuarter = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteQuarter.png"));

        builder
            .WithTile(black, new([0]), new([0]), new([0]), new([0]))
            .WithTile(blackDouble, new([0]), new([1]), new([0]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone)
            .WithTile(blackHalf, new([0]), new([1]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(blackQuarter, new([0]), new([0]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(white, new([1]), new([1]), new([1]), new([1]))
            .WithTile(whiteDouble, new([1]), new([0]), new([1]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone)
            .WithTile(whiteHalf, new([1]), new([0]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(whiteQuarter, new([1]), new([1]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithRuleset()
            .WithName("CircularShapes");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreateCirclesTileset()
    {
        TilesetBuilder builder = new();

        Bitmap black = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "Black.png"));
        Bitmap blackDouble = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackDouble.png"));
        Bitmap blackHalf = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackHalf.png"));
        Bitmap blackQuarter = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "BlackQuarter.png"));
        Bitmap white = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "White.png"));
        Bitmap whiteDouble = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteDouble.png"));
        Bitmap whiteHalf = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteHalf.png"));
        Bitmap whiteQuarter = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circles", "WhiteQuarter.png"));

        builder
            .WithTile(black, new([0]), new([0]), new([0]), new([0]))
            .WithTile(blackDouble, new([2]), new([1]), new([2]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(blackHalf, new([2]), new([1]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(blackQuarter, new([1, 0, 0]), new([0, 0, 1]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(white, new([1]), new([1]), new([1]), new([1]))
            .WithTile(whiteDouble, new([3]), new([0]), new([3]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(whiteHalf, new([3]), new([0]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(whiteQuarter, new([0, 1, 1]), new([1, 1, 0]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithRuleset()
            .WithName("Circles");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreatePipesTileset()
    {
        TilesetBuilder builder = new();

        Bitmap blank = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Pipes", "Blank.png"));
        Bitmap t = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Pipes", "T.png"));

        builder
            .WithTile(blank, new([0]), new([0]), new([0]), new([0]))
            .WithTile(t, new([0]), new([1]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithRuleset()
            .WithName("Pipes");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreateCircuitTileset()
    {
        TilesetBuilder builder = new();

        Bitmap box = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "Box.png"));
        Bitmap boxCorner = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "BoxCorner.png"));
        Bitmap mask = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "Mask.png"));
        Bitmap pad = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "Pad.png"));
        Bitmap trace = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "Trace.png"));
        Bitmap traceBoxConnector = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceBox.png"));
        Bitmap traceCorner = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceCorner.png"));
        Bitmap traceDouble = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceDouble.png"));
        Bitmap tracePad = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TracePad.png"));
        Bitmap traceT = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceT.png"));
        Bitmap traceWire = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceWire.png"));
        Bitmap traceWirePad = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "TraceWirePad.png"));
        Bitmap wire = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Circuit", "Wire.png"));

        builder
            .WithTile(box, new([0]), new([0]), new([0]), new([0]))
            .WithTile(boxCorner, new([0, 1]), new([1]), new([1]), new([1, 0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(mask, new([1]), new([1]), new([1]), new([1]))
            .WithTile(pad, new([1]), new([2]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(trace, new([1]), new([2]), new([1]), new([2]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(traceBoxConnector, new([0, 1]), new([2]), new([1, 0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(traceCorner, new([2]), new([2]), new([1]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(traceDouble, new([2]), new([2]), new([2]), new([2]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(tracePad, new([1]), new([2]), new([1]), new([2]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(traceT, new([2]), new([2]), new([1]), new([2]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(traceWire, new([3]), new([2]), new([3]), new([2]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(traceWirePad, new([3]), new([1]), new([2]), new([1]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(wire, new([1]), new([3]), new([1]), new([3]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithRuleset()
            .WithName("Circuits");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }

    public static async Task CreateRailsTileset()
    {
        TilesetBuilder builder = new();

        Bitmap blank = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "Blank.png"));
        Bitmap cross = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "Cross.png"));
        Bitmap i = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "I.png"));
        Bitmap iSide = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "ISide.png"));
        Bitmap l = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "L.png"));
        Bitmap smallL = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "SmallL.png"));
        Bitmap t = (Bitmap)Image.FromFile(Path.Combine(TileImagePath, "Rails", "T.png"));

        builder
            .WithTile(blank, new([0]), new([0]), new([0]), new([0]))
            .WithTile(cross, new([0, 1, 0]), new([0, 1, 0]), new([0, 1, 0]), new([0, 1, 0]))
            .WithTile(i, new([0, 1, 0]), new([0]), new([0, 1, 0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone)
            .WithTile(iSide, new([1, 0, 0]), new([0]), new([0, 0, 1]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(l, new([1, 0, 0]), new([0, 0, 1]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(smallL, new([0, 1, 0]), new([0, 1, 0]), new([0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithTile(t, new([0, 1, 0]), new([0, 1, 0]), new([0, 1, 0]), new([0]), Transform.RotateNoneFlipNone, Transform.Rotate90FlipNone, Transform.Rotate180FlipNone, Transform.Rotate270FlipNone)
            .WithRuleset()
            .WithName("Rails");

        await TilesetFileHelper.SaveTilesetAsync(builder.Build());
    }
}