using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Test.Models;

[TestClass]
public class TransformTest
{
    public static IEnumerable<(Transform transform, TransformableInt up, TransformableInt right, TransformableInt down, TransformableInt left, (TransformableInt up, TransformableInt right, TransformableInt down, TransformableInt left) expected)> TransformItems_RotatesItemsCorrectly_Data =>
    [
        (Transform.RotateNoneFlipNone, new(0), new(1), new(2), new(3), (new(0),        new(1),         new(2),         new(3))),
        (Transform.RotateNoneFlipX,    new(0), new(1), new(2), new(3), (new(2, true),  new(1, true),   new(0, true),   new(3, true))),
        (Transform.RotateNoneFlipY,    new(0), new(1), new(2), new(3), (new(0, true),  new(3, true),   new(2, true),   new(1, true))),
        (Transform.RotateNoneFlipXY,   new(0), new(1), new(2), new(3), (new(2),        new(3),         new(0),         new(1))),
        (Transform.Rotate90FlipNone,   new(0), new(1), new(2), new(3), (new(3),        new(0),         new(1),         new(2))),
        (Transform.Rotate90FlipX,      new(0), new(1), new(2), new(3), (new(1, true),  new(0, true),   new(3, true),   new(2, true))),
        (Transform.Rotate90FlipY,      new(0), new(1), new(2), new(3), (new(3, true),  new(2, true),   new(1, true),   new(0, true))),
        (Transform.Rotate90FlipXY,     new(0), new(1), new(2), new(3), (new(1),        new(2),         new(3),         new(0))),
        (Transform.Rotate180FlipNone,  new(0), new(1), new(2), new(3), (new(2),        new(3),         new(0),         new(1))),
        (Transform.Rotate180FlipX,     new(0), new(1), new(2), new(3), (new(0, true),  new(3, true),   new(2, true),   new(1, true))),
        (Transform.Rotate180FlipY,     new(0), new(1), new(2), new(3), (new(2, true),  new(1, true),   new(0, true),   new(3, true))),
        (Transform.Rotate180FlipXY,    new(0), new(1), new(2), new(3), (new(0),        new(1),         new(2),         new(3))),
        (Transform.Rotate270FlipNone,  new(0), new(1), new(2), new(3), (new(1),        new(2),         new(3),         new(0))),
        (Transform.Rotate270FlipX,     new(0), new(1), new(2), new(3), (new(3, true),  new(2, true),   new(1, true),   new(0, true))),
        (Transform.Rotate270FlipY,     new(0), new(1), new(2), new(3), (new(1, true),  new(0, true),   new(3, true),   new(2, true))),
        (Transform.Rotate270FlipXY,    new(0), new(1), new(2), new(3), (new(3),        new(0),         new(1),         new(2)))
    ];

    [TestMethod]
    [DynamicData(nameof(TransformItems_RotatesItemsCorrectly_Data))]
    public void TransformItems_RotatesItemsCorrectly(Transform transform,
        TransformableInt up, TransformableInt right, TransformableInt down, TransformableInt left,
        (TransformableInt up, TransformableInt right, TransformableInt down, TransformableInt left) expected)
    {
        var actual = transform.TransformItems(up, right, down, left);

        // Each tuple item must be checked separatly
        string errorMessage = $"({transform})";
        Assert.AreEqual(expected.up, actual.up, errorMessage);
        Assert.AreEqual(expected.right, actual.right, errorMessage);
        Assert.AreEqual(expected.down, actual.down, errorMessage);
        Assert.AreEqual(expected.left, actual.left, errorMessage);
    }

    [TestMethod]
    public void TransformItems_ThrowsException_IncorrectEnumValue()
    {
        Transform incorrectValue = (Transform)(-1);
        Assert.ThrowsException<ArgumentException>(() => incorrectValue.TransformItems<TransformableInt>(new(), new(), new(), new()));
    }

    public class TransformableInt(int value = 0, bool reversed = false) : ITransformable
    {
        public int Value { get; set; } = value;
        public bool Reversed { get; set; } = reversed;

        public ITransformable Reverse()
        {
            Reversed = !Reversed;
            return this;
        }

        public override string ToString() => $"{Value}{(Reversed ? "*" : "")}";

        public override bool Equals(object? obj)
        {
            return obj is TransformableInt other && Value == other.Value && Reversed == other.Reversed;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Reversed);
        }
    }
}