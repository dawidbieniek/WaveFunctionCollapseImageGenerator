using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

public class TilesetViewModel : ITilesetProvider
{
    public Tileset Tileset
    {
        get
        {
            TilesetBuilder builder = new();

            //Bitmap oneImage = new(20, 20);
            //using (Graphics g = Graphics.FromImage(oneImage))
            //{
            //    g.Clear(Color.White);
            //}
            //Bitmap twoImage = new(20, 20);
            //using (Graphics g = Graphics.FromImage(twoImage))
            //{
            //    g.Clear(Color.White);
            //    g.FillRectangle(new SolidBrush(Color.Red), new(0, 0, 10, 10));
            //}
            //Bitmap threeImage = new(20, 20);
            //using (Graphics g = Graphics.FromImage(threeImage))
            //{
            //    g.Clear(Color.White);
            //    g.FillRectangle(new SolidBrush(Color.Blue), new(0, 0, 10, 10));
            //}
            //Bitmap fourImage = new(20, 20);
            //using (Graphics g = Graphics.FromImage(fourImage))
            //{
            //    g.Clear(Color.White);
            //    g.FillRectangle(new SolidBrush(Color.Red), new(0, 0, 10, 10));
            //    g.FillRectangle(new SolidBrush(Color.Blue), new(10, 10, 10, 10));
            //}

            //builder
            //    .WithTile(oneImage, new([0]), new([0]), new([0]), new([0]))
            //    .WithTile(twoImage, new([1, 0]), new([0]), new([0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            //    .WithTile(threeImage, new([2, 0]), new([0]), new([0]), new([0, 2]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            //    .WithTile(fourImage, new([1, 0]), new([0, 2]), new([2, 0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
            //    .WithRuleset();

            Bitmap oneImage = new(20, 20);
            using (Graphics g = Graphics.FromImage(oneImage))
            {
                g.Clear(Color.White);
            }
            Bitmap middleImage = new(20, 20);
            using (Graphics g = Graphics.FromImage(middleImage))
            {
                g.Clear(Color.Blue);
            }
            Bitmap cornerImage = new(20, 20);
            using (Graphics g = Graphics.FromImage(cornerImage))
            {
                g.Clear(Color.White);
                g.FillRectangle(new SolidBrush(Color.Blue), new(0, 0, 10, 10));
            }
            Bitmap lineImage = new(20, 20);
            using (Graphics g = Graphics.FromImage(lineImage))
            {
                g.Clear(Color.White);
                g.FillRectangle(new SolidBrush(Color.Blue), new(0, 0, 20, 10));
            }

            builder
                .WithTile(oneImage, new([0]), new([0]), new([0]), new([0]))
                .WithTile(middleImage, new([1, 1]), new([1, 1]), new([1, 1]), new([1, 1]))
                .WithTile(cornerImage, new([1, 0]), new([0]), new([0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
                .WithTile(lineImage, new([1, 1]), new([1, 0]), new([0]), new([0, 1]), Transform.RotateNoneFlipNone, Transform.Rotate180FlipNone, Transform.Rotate90FlipNone, Transform.Rotate270FlipNone)
                .WithRuleset();

            return builder.Build();
        }
    }
}