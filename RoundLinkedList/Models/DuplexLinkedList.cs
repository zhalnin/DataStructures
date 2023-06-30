﻿using System.Collections;

namespace RoundLinkedList.Models;

internal class DuplexLinkedList<T> : IEnumerable<T>
{
    public DuplexItem<T> Head { get; set; }
    public DuplexItem<T> Tail { get; set; }
    public int Count { get; set; }

    public DuplexLinkedList()
    {
        
    }

    public DuplexLinkedList(T data)
    {
        SetHeadAndTail(data);
    }

    public void Add(T data)
    {
        if (Count == 0)
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
        var current = Head;
        while (current != null)
        {
            if(current.Data.Equals(data))
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
                return;
            }
            current = current.Next;
        }
    }

    public DuplexLinkedList<T> Reverse()
    {
        var result = new DuplexLinkedList<T>();

        var current = Tail;
        while(current != null)
        {
            result.Add(current.Data);
            current = current.Previous;
        }
        return result;
    }

    private void SetTail(T data)
    {
        var item = new DuplexItem<T>(data);
        Tail.Next = item;
        item.Previous = Tail;
        Tail = item;
        Count++;
    }

    private void SetHeadAndTail(T data)
    {
        var item = new DuplexItem<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        while(current != null)
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
