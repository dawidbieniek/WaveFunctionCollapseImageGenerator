namespace WaveFunctionCollapseImageGenerator.Models.Common;

public enum Direction
{
    Up,
    Right,
    Down,
    Left
}

public static class DirectionExtensions
{
    public static Direction Opposite(this Direction direction)
    {
        return direction switch
        {
            Direction.Up => Direction.Down,
            Direction.Right => Direction.Left,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            _ => throw new ArgumentException($"Invalid direction ({direction})"),
        };
    }
}