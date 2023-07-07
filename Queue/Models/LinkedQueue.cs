namespace Queue.Models;

public class LinkedQueue<T>
{
    private Item<T> head;
    private Item<T> tail;

    public int Count { get; private set; }

    public LinkedQueue()
    {
        
    }

    public LinkedQueue(T data) =>
        SetHeadAndTail(data);

    public void Enqueue(T data)
    {
        //if(tail != null)
        if(Count == 0)
        {
            SetHeadAndTail(data);
        }
        else
        {
            SetTail(data);
        }
    }

    public T Dequeue()
    {
        var data = tail.Data;

        var current = tail.Next;
        var previous = tail;
        while(current != null && current.Next != null)
        {
            previous = current;
            current = current.Next;
        }
        head = previous;
        head.Next = null;
        Count--;
        return data;
    }

    public T Peek()
    {
        return head.Data;
    }

    private void SetHeadAndTail(T data)
    {
        var item = new Item<T>(data);
        head = item;
        tail = item;
        Count = 1;
    }

    private void SetTail(T data)
    {
        var item = new Item<T>(data)
        {
            Next = tail
        };
        tail = item;
        Count++;
    }
}
