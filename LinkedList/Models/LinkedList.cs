﻿using System.Collections;

namespace LinkedList.Models;

internal class LinkedList<T> : IEnumerable
{
    public Item<T> Head { get; private set; }
    public Item<T> Tail { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        Clear();
    }

    public LinkedList(T data) =>
        SetHeadAndTail(data);

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = default;
    }

    public void AppendHead(T data)
    {
        if (Head != null)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        else
        {
            SetHeadAndTail(data);
        }
    }

    public void InsertAfter(T target, T data)
    {
        if (Head != null)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(target))
                {
                    var item = new Item<T>(data)
                    {
                        Next = current.Next
                    };
                    current.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
        else
        {
            //SetHeadAndTail(target);
            //Add(data);
        }
    }

    public void Add(T data)
    {
        if (Tail != null)
        {
            SetTail(data);
        }
        else
        {
            SetHeadAndTail(data);
        }
    }

    public void Delete(T data)
    {
        if (Head != null)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Count--;
                return;
            }

            var current = Head.Next;
            var previous = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    previous.Next = current.Next;
                    Count--;
                    return;
                }

                previous = current;
                current = current.Next;
            }
        }
    }

    private void SetHeadAndTail(T data)
    {
        var item = new Item<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }

    private void SetTail(T data)
    {
        var item = new Item<T>(data);
        Tail.Next = item;
        Tail = item;
        Count++;
    }

    public IEnumerator GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public override string ToString()
    {
        return $"Linked list {Count} elements";
    }
}