namespace BinaryHeap.Models;

internal class Heap<T> where T : IComparable<T>
{
    private List<T> _items = new List<T>();
    public int Count => _items.Count;

    public T Peek()
    {
        if (Count <= 0)
        {
            return default(T);
        }

        return _items[0];
    }

    public void Add(T item)
    {
        _items.Add(item);

        var currentIndex = Count -1;//48.08
        var parentIndex = GetParentIndex(currentIndex);

        while (currentIndex > 0 && _items[parentIndex].CompareTo(_items[currentIndex]) < 0)
        {
            Swap(currentIndex, parentIndex);

            currentIndex = parentIndex;
            parentIndex = GetParentIndex(currentIndex);
        }
    }

    private void Swap(int currentIndex, int parentIndex) =>
        (_items[currentIndex], _items[parentIndex]) = (_items[parentIndex], _items[currentIndex]);

    private int GetParentIndex(int currentIndex) => (currentIndex - 1) / 2;
}
