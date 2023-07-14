using System.Collections;

namespace Set.Models;

internal class EasySet<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();
    public int Count => _items.Count;
    public EasySet()
    {
        
    }
    public EasySet(T item)
    {
        _items.Add(item);
    }

    public EasySet(IEnumerable<T> items)
    {
        _items = items.ToList();
    }

    public void Add(T item)
    {
        //foreach (T item2 in _items)
        //{
        //    if(item2.Equals(item))
        //    {
        //        return;
        //    }
        //}
        if(_items.Contains(item)) { return; }

        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public EasySet<T> Union(EasySet<T> set)
    {
        EasySet<T> result = new();
        foreach (var item in _items)
        {
            result.Add(item);
        }

        foreach (var item in set._items)
        {
            result.Add(item);
        }
        return result;
        //return new EasySet<T>(_items.Union(set._items));
    }

    public EasySet<T> Intersection(EasySet<T> set)
    {
        var result = new EasySet<T>();
        EasySet<T> big;
        EasySet<T> small;
        if (Count >= set.Count)
        {
            big = this;
            small = set;
        }
        else
        {
            big = set;
            small = this;
        }

        foreach (var item in small._items)
        {
            foreach (var item2 in big._items)
            {
                if (item.Equals(item2))
                {
                    result.Add(item);
                    break;
                }
            }
        }
        return result;

        // return new EasySet<T>(_items.Intersect(set._items));
    }

    public EasySet<T> Difference(EasySet<T> set)
    {
        var result = new EasySet<T>(_items);
        foreach (var item in set._items)
        {
            result.Remove(item);
        }
        return result;
        //return new EasySet<T>(_items.Except(set._items));
    }

    public bool Subset(EasySet<T> set)
    {
        foreach (var item in _items)
        {
            var equals = false;
            foreach (var item2 in set._items)
            {
                if(item.Equals(item2))
                {
                    equals = true;
                    break;
                }
            }
            if(!equals)
            {
                return false;
            }
        }
        return true;
        //return set._items.All(i => _items.Contains(i));
    }

    public EasySet<T> SymmetricDifference(EasySet<T> set)
    {
        var result = new EasySet<T>();

        foreach (var item in _items)
        {
            var equals = false;
            foreach (var item2 in set._items)
            {
                if (item.Equals(item2))
                {
                    equals = true;
                    break;
                }
            }
            if (!equals)
            {
                result.Add(item);
            }
        }


        foreach(var item in set._items)
        {
            var equals = false;
            foreach (var item2 in _items)
            {
                if (item.Equals(item2))
                {
                    equals = true;
                    break;
                }
            }
            if (!equals)
            {
                result.Add(item);
            }
        }
        return result;

        //return new EasySet<T>(_items.Except(set._items).Union(set._items.Except(_items)));
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
