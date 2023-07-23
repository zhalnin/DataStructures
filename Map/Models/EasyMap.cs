using System.Collections;

namespace Map.Models;

internal class EasyMap<TKey, TValue> : IEnumerable
{
    private List<Item<TKey, TValue>> _items = new List<Item<TKey, TValue>>();
    private List<TKey> _keys = new List<TKey>();
    public int Count => _items.Count;

    public EasyMap()
    {
            
    }

    public void Add(Item<TKey, TValue> item)
    {
        if(!_keys.Contains(item.Key))
        {
            _items.Add(item);
            _keys.Add(item.Key);
        }
    }

    public TValue Search(TKey key)
    {
        if(_keys.Contains(key))
        {
            return _items.Single(i => i.Key.Equals(key)).Value;
        }
        return default(TValue);
    }

    public void Remove(TKey key)
    {
        if( _keys.Contains(key))
        {
            _items.Remove(_items.Single(i => i.Key.Equals(key)));
            _keys.Remove(key);
        }
    }

    public IEnumerator GetEnumerator()
    {
        //return _items.GetEnumerator();
        foreach (var item in _items)
        {
            yield return item;
        }
    }
}
