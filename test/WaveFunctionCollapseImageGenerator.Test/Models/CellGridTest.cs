using WaveFunctionCollapseImageGenerator.Models.Cells;

namespace WaveFunctionCollapseImageGenerator.Test.Models;

[TestClass]
public class CellGridTest
{
    [TestMethod]
    public void GetNeighboursOfCell_ReturnsCorrectNeighbours_InMiddle()
    {
        CellGrid grid = new(3, 3, false, []);

        (Cell? up, Cell? right, Cell? down, Cell? left) = grid.GetNeighboursOfCell(1, 1);

        Assert.AreEqual(grid[0, 1], up, "Up");
        Assert.AreEqual(grid[1, 2], right, "Right");
        Assert.AreEqual(grid[2, 1], down, "Down");
        Assert.AreEqual(grid[1, 0], left, "Left");
    }

    [TestMethod]
    public void GetNeighboursOfCell_ReturnsCorrectNeighbours_AtEdgeWithoutWrapping()
    {
        CellGrid grid = new(3, 3, false, []);

        (Cell? up, Cell? right, Cell? down, Cell? left) = grid.GetNeighboursOfCell(0, 0);

        Assert.IsNull(up, "Up");
        Assert.AreEqual(grid[0, 1], right, "Right");
        Assert.AreEqual(grid[1, 0], down, "Down");
        Assert.IsNull(left, "Left");
    }

    [TestMethod]
    public void GetNeighboursOfCell_ReturnsCorrectNeighbours_AtEdgeWithWrapping()
    {
        CellGrid grid = new(3, 3, true, []);

        (Cell? up, Cell? right, Cell? down, Cell? left) = grid.GetNeighboursOfCell(0, 0);

        Assert.AreEqual(grid[2, 0], up, "Up");
        Assert.AreEqual(grid[0, 1], right, "Right");
        Assert.AreEqual(grid[1, 0], down, "Down");
        Assert.AreEqual(grid[0, 2], left, "Left");
    }
}