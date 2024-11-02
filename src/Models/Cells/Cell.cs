namespace WaveFunctionCollapseImageGenerator.Models.Cells;

public class Cell(IList<int> possibleStates, Random rnd)
{
    private readonly Random _rnd = rnd;
    private IList<int> _possibleStates = possibleStates;

    public bool Collapsed { get; private set; } = false;
    /// <summary>
    /// Number of possible states this cell can be
    /// </summary>
    public int Entropy => _possibleStates.Count;
    public bool CanBeCollapsed => !Collapsed && _possibleStates.Count > 0;
    public int? CurrentState => Collapsed ? _possibleStates[0] : null;

    public void RemoveStates(params IEnumerable<int> states)
    {
        if (Collapsed)
            return;

        foreach (int stateToRemove in states)
        {
            _possibleStates.Remove(stateToRemove);
        }
    }

    /// <summary>
    /// Collapses possible states of cell into one that is certain
    /// </summary>
    /// <returns> The state cell collapsed to </returns>
    /// <exception cref="InvalidOperationException"> </exception>
    public int Collapse()
    {
        if (_possibleStates.Count == 0)
            throw new InvalidOperationException("Cell cannot be collapsed. It has no possible states");

        int newState = _possibleStates[_rnd.Next(_possibleStates.Count)];
        _possibleStates = [newState];

        Collapsed = true;

        return newState;
    }
}