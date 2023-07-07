using System.ComponentModel.DataAnnotations;

namespace Queue.Models;

public class DuplexLinkedDeque<T>
{
    private DuplexItem<T> Head;
    private DuplexItem<T> Tail;
    public int Count { get; private set; }

    public DuplexLinkedDeque()
    {
        
    }

    public DuplexLinkedDeque(T data) =>  
        SetHeadAndTail(data);

    public void PushBack(T data)
    {
        if(Count == 0)
        {
            SetHeadAndTail(data);
        }
        else
        {
            SetTail(data);
        }
    }

    public void PushFront(T data)
    {
        if(Count == 0)
        {
            SetHeadAndTail(data);
        }
        else
        {
            SetHead(data);
        }
    }

    public T PopBack()
    {
        if(Count >0)
        {
            var result = Tail.Data;
            var current = Tail.Next;
            current.Previous = null;
            Tail = current;
            Count--;
            return result;
        }
        else
        {
            return default(T);
        }
    }
    
    public T PopFront()
    {
        if(Count > 0)
        {
            var result = Head.Data;
            var current = Head.Previous;
            current.Next = null;
            Head = current;
            Count--;
            return result;
        }
        else
        {
            return default(T);
        }
    }

    private void SetHeadAndTail(T data)
    {
        var item = new DuplexItem<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }

    public T PeekBack()
    {
        return Tail.Data;
    }

    public T PeekFront()
    {
        return Head.Data;
    }

    private void SetTail(T data)
    {
        var item = new DuplexItem<T>(data);
        item.Next = Tail;
        Tail.Previous = item;
        Tail = item;
        Count++;
    }

    private void SetHead(T data)
    {
        var item = new DuplexItem<T>(data);
        item.Previous = Head;
        Head.Next = item;
        Head = item;
        Count++;
    }
}
