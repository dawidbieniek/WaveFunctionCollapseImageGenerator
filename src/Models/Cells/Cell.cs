using System.Collections.ObjectModel;

namespace WaveFunctionCollapseImageGenerator.Models.Cells;

public class Cell(IList<int> possibleStates, Random random)
{
    private readonly Random _random = random;
    private IList<int> _possibleStates = possibleStates;

    /// <summary>
    /// Creates deep clone of <see cref="Cell"/> from <paramref name="other"/>
    /// </summary>
    /// <param name="other"> </param>
    public Cell(Cell other) : this([.. other._possibleStates], other._random)
    {
        Collapsed = other.Collapsed;
    }

    public bool Collapsed { get; private set; } = false;
    public ReadOnlyCollection<int> PossibleStates => _possibleStates.AsReadOnly();
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
    /// <param name="stateToCollapseTo">
    /// One of <see cref="possibleStates"/> the cell should collapse to. If null then random is choosen
    /// </param>
    /// <exception cref="InvalidOperationException"> </exception>
    public int Collapse(int? stateToCollapseTo = null)
    {
        if (_possibleStates.Count == 0)
            throw new InvalidOperationException("Cell cannot be collapsed, it has no possible states");

        int newState;
        if (stateToCollapseTo is not null)
        {
            if (!_possibleStates.Contains(stateToCollapseTo.Value))
                throw new InvalidOperationException($"Cell cannot be collapsed to {stateToCollapseTo}");
            newState = stateToCollapseTo.Value;
        }
        else
            newState = _possibleStates[_random.Next(_possibleStates.Count)];

        _possibleStates = [newState];
        Collapsed = true;

        return newState;
    }
}