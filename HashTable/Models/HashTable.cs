﻿namespace HashTable.Models;

internal class HashTable<T>
{
    private Item<T>[] _items;
    public HashTable(int size)
    {
        _items = new Item<T>[size];
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i] = new Item<T>(i);
        }
    }

    public void Add(T item)
    {
        var key = GetHash(item);
        _items[key].Nodes.Add(item);
    }

    public bool Search(T item)
    {
        var key = GetHash(item);
        return _items[key].Nodes.Contains(item);
    }

    private int GetHash(T item)
    {
        return  item.GetHashCode() % _items.Length;
    }
}
