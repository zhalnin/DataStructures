using System.Collections;

namespace Map.Models;

internal class Dict<TKey, TValue> : IEnumerable
{
    private int size = 100;
    private readonly Item<TKey, TValue>[] _items;

    public Dict() 
    {
        _items = new Item<TKey, TValue>[size];
    }

    public void Add(Item<TKey, TValue> item)
    {
        var hash = GetHash(item.Key);
        if (_items[hash] == null) 
        {
            _items[hash] = item;
        }
        else
        {
            var placed = false;
            for (int i = hash; i < size; i++)
            {
                if (_items[i] == null)
                {
                    _items[i] =  item;
                    placed = true;
                    break;
                }

                if (_items[i].Key.Equals(item.Key))
                {
                    return;
                }
            }

            if(!placed)
            {
                for(int i = 0; i < hash; i++)
                {
                    if (_items[i] == null)
                    {
                        _items[i] = item;
                        placed = true;
                        break;
                    }

                    if (_items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                }
            }

            if (!placed)
            {
                throw new Exception("The dicitionary is full");
            }
        }
    }

    public void Remove(TKey key)
    {
        var hash = GetHash(key);
        if (_items[hash] == null)
        {
            return;
        }

        if (_items[hash].Key.Equals(key))
        {


            var replaced = false;
            for (int i = hash; i < size; i++)
            {
                if (_items[i] != null && !_items[i].Key.Equals(key) && key.Equals(GetHash(_items[i].Key)))
                {
                    _items[hash].Key = _items[i].Key;
                    _items[hash].Value = _items[i].Value;
                    //oldItem = _items[i];
                    _items[i] = null;
                    replaced = true;
                    break;
                }
            }

            if (!replaced)
            {
                for (int i = 0; i < hash; i++)
                {
                    if (_items[i] != null && !_items[i].Key.Equals(key) && key.Equals(GetHash(_items[i].Key)))
                    {
                        _items[hash].Key = _items[i].Key;
                        _items[hash].Value = _items[i].Value;
                        //oldItem = _items[i];
                        _items[i] = null;
                        replaced = true;
                        break;
                    }
                }
            }

            //if (oldItem != null)
            //{
            //    oldItem.Key = _items[hash].Key;
            //    oldItem.Value = _items[hash].Value;
            //    _items[hash] = oldItem;
            //    //oldItem = null;
            //}
            if (!replaced)
            {
                _items[hash] = null;
            }
        }
        else
        {
            for (int i = hash; i < size; i++)
            {
                if (_items[i] == null)
                {
                    return;
                }

                if (_items[i].Key.Equals(key))
                {
                    _items[i] = null;
                    return;
                }
            }

            for (int i = 0; i < hash; i++)
            {
                if (_items[i] == null)
                {
                    return;
                }

                if (_items[i].Key.Equals(key))
                {
                    _items[i] = null;
                    return;
                }
            }
        }
    }

    public TValue Search(TKey key)
    {
        var hash = GetHash(key);
        if (_items[hash] == null)
        {
            return default(TValue);
        }

        if (_items[hash].Key.Equals(key))
        {
            return _items[hash].Value;
        }
        else
        {
            var placed = false;
            for (int i = hash; i < size; i++)
            {
                if (_items[i] == null)
                {
                    return default(TValue);
                }

                if (_items[i].Key.Equals(key))
                {
                    return _items[i].Value;
                }
            }

            for (int i = 0; i < hash; i++)
            {
                if (_items[i] == null)
                {
                    return default(TValue);
                }

                if (_items[i].Key.Equals(key))
                {
                    return _items[i].Value;
                }
            }
        }
        return default(TValue);
    }

    private int GetHash(TKey key)
    {
        return key.GetHashCode() % size;
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in _items)
        {
            if(item != null)
            {
                yield return item;
            }
        }
    }
}
