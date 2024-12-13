namespace WaveFunctionCollapseImageGenerator.Models.Exceptions;

[Serializable]
public class BacktrackingStackEmptyException : Exception
{
    public BacktrackingStackEmptyException()
    { }

    public BacktrackingStackEmptyException(string message) : base(message)
    {
    }

    public BacktrackingStackEmptyException(string message, Exception inner) : base(message, inner)
    {
    }
}