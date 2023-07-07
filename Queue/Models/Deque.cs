namespace Queue.Models;

public class Deque<T>
{
    private List<T> _items = new List<T>();
    private T Head => _items.Last();
    private T Tail => _items.First();
    public int Count => _items.Count;

    public Deque()
    {
        
    }

    public Deque(T data)
    {
        _items.Add(data);
    }

    public void PushBack(T data)
    {
        _items.Insert(0, data);
    }

    public void PushFront(T data)
    {
        _items.Add(data);
    }

    public T PopBack()
    {
        var item = Tail;
        _items.Remove(item);
        return item;
    }

    public T PopFront()
    {
        var item = Head;
        _items.Remove(item);
        return item;
    }

    public T PeekBack()
    {
        return Tail;
    }

    public T PeekFront()
    {
        return Head;
    }
}
