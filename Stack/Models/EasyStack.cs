namespace Stack.Models;

internal class EasyStack<T> : ICloneable
{
    private List<T> items = new List<T>();

    public int Count => items.Count;

    public bool IsEmpty => items.Count == 0;

    public void Push(T item)
    {
        items.Add(item);
    }

    public void Clear()
    {
        items.Clear();
    }

    public T Pop()
    {
        if (!IsEmpty)
        {
            var item = items.LastOrDefault();
            items.Remove(item);
            return item;
        }
        else
        {
            throw new NullReferenceException("The stack is empty.");
        }
    }

    public T Peek()
    {
        if(!IsEmpty)
        {
            return items.LastOrDefault();
        }
        else
        {
            throw new NullReferenceException("The stack is empty");
        }
    }

    public override string ToString()
    {
        return $"The stack contains {Count} elements.";
    }

    public object Clone()
    {
        var newStack = new EasyStack<T>
        {
            items = new List<T>(items)
        };
        return newStack;
    }
}
