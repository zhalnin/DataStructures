using System.Collections;

namespace CircularLinkedList.Models;

internal class CircularLinkedList<T> : IEnumerable<T>
{
    public DuplexItem<T> Head { get; set; }
    public int Count { get; set; }
    public CircularLinkedList()
    {
        
    }

    public CircularLinkedList(T data)
    {
        Head = new DuplexItem<T>(data);
        Count = 1;
    }

    public  void Add(T data)
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

    public void Delete(T data)
    {
        if(Head.Data.Equals(data))
        {
            RemoveItem(Head);
            Head = Head.Next;
            return;
        }

        var current = Head;
        for (int i = Count; i > 0; i--)
        {
            if(current != null && current.Data.Equals(data))
            {
                RemoveItem(current);
            }
            current = current.Next;
        }
    }

    private void RemoveItem(DuplexItem<T> current)
    {
        current.Next.Previous = current.Previous;
        current.Previous.Next = current.Next;
        Count--;
    }

    private void SetHeadAndTail(T data)
    {
        var item = new DuplexItem<T>(data);
        Head = item;
        Head.Next = Head;
        Head.Previous = Head;
        Count = 1;
    }

    private void SetTail(T data)
    {
        var item = new DuplexItem<T>(data);
        item.Next = Head;
        item.Previous = Head.Previous;
        Head.Previous.Next = item;
        Head.Previous = item;
        Count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        for(int i = 0; i < Count; i++)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
