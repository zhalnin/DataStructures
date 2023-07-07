namespace Queue.Models;

public  class Queue<T>
{
    private readonly List<T> _items = new List<T>();
    private T Head => _items.Last();
    private T Tail => _items.First();
    public int Count => _items.Count;

    public Queue()
    {
        
    }

    public Queue(T data)
    {
        _items.Add(data);
    }

    public void Enqueue(T data)
    {
        _items.Insert(0, data);
    }

    public T Dequeue()
    {
        var item = Head;
        _items.Remove(item);
        return item;
    }

    public T Peek()
    {
        return Head;
    }
}