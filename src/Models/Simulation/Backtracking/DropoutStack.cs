namespace WaveFunctionCollapseImageGenerator.Models.Simulation.Backtracking;

/// <summary>
/// Simple stack collection that removes first elements when there are no more space
/// </summary>
public class DropoutStack<T>
{
    private readonly LinkedList<T> _data;

    public DropoutStack(int maxSize)
    {
        _data = new LinkedList<T>();
        MaxSize = maxSize;
    }

    public DropoutStack(DropoutStack<T> other, int maxSize)
    {
        _data = new LinkedList<T>();
        MaxSize = Math.Min(maxSize, other.MaxSize);

        // Copy data from behind of list
        int i = 0;
        LinkedListNode<T>? node = other._data.Last;
        while (node is not null && i < maxSize)
        {
            _data.AddLast(node.Value);

            node = node.Previous;
            i++;
        }
    }

    public int Count => _data.Count;

    public int MaxSize { get; }

    public void Push(T element)
    {
        _data.AddLast(element);
        if (_data.Count > MaxSize)
        {
            _data.RemoveFirst();
        }
    }

    public T Pop()
    {
        if (_data.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T value = _data.Last!.Value;
        _data.RemoveLast();
        return value;
    }

    public T Peek()
    {
        return _data.Count == 0
            ? throw new InvalidOperationException("Stack is empty")
            : _data.Last!.Value;
    }

    public void Clear()
    {
        _data.Clear();
    }
}