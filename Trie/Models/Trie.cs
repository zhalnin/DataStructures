using System.Data;

namespace Trie.Models;

internal class Trie<T>
{
    private Node<T> root;
    public int Count { get; set; }

    public Trie()
    {
        root = new Node<T>('\0', default(T), string.Empty);
        Count++;
    }
    public void Add(string key, T data)
    {
        root.Add(key, data, root);
    }

    public void Remove(string key)
    {
        root.Remove(key, root);
    }

    public bool TrySearch(string key, out T value)
    {
        return root.TrySearch(key, root, out value);
    }
}
