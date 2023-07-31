namespace Trie.Models;

internal class Node<T>
{
    public char Symbol { get; set; }
    public T Data { get; set; }
    public bool IsWord { get; set; }
    public string Prefix { get; set; }
    public Dictionary<char, Node<T>> SubNodes { get; set; }

    public Node(T data)
    {
        Data = data;
    }

    public Node(char symbol, T data, string prefix)
    {
        Symbol = symbol;
        Data = data;
        SubNodes = new Dictionary<char, Node<T>>();
        Prefix = prefix;
    }

    public void Add(string key, T data, Node<T> node)
    {
        if (string.IsNullOrEmpty(key))
        {
            if (!node.IsWord)
            {
                node.Data = data;
                node.IsWord = true;
            }
        }
        else
        {
            var symbol = key[0];
            var subnode = node.TryFind(symbol);
            if (subnode != null)
            {
                Add(key.Substring(1), data, subnode);
            }
            else
            {
                var newNode = new Node<T>(key[0], data, node.Prefix + key[0]);
                node.SubNodes.Add(key[0], newNode);
                Add(key.Substring(1), data, newNode);
            }
        }
    }

    public void Remove(string key, Node<T> node)
    {
        if (string.IsNullOrEmpty(key))
        {
            if (node.IsWord)
            {
                node.IsWord = false;
            }
        }
        else
        {
            var symbol = key[0];
            var subNode = node.TryFind(symbol);
            if (subNode != null)
            {
                Remove(key.Substring(1), subNode);
            }
        }
    }

    public bool TrySearch(string key, Node<T> node, out T value)
    {
        value = default(T);
        bool result = false;

        if (string.IsNullOrEmpty(key))
        {
            if(node.IsWord)
            {
                value = node.Data;
                result = true;
            }
        }
        else
        {
            var symbol = key[0];
            var subNode = node.TryFind(symbol);
            if (subNode != null)
            {
                result = TrySearch(key.Substring(1), subNode, out value);
            }
        }
        return result;
    }

    public Node<T>? TryFind(char symbol)
    {
        if (SubNodes.TryGetValue(symbol, out Node<T>? value)) return value;
        else return null;
    }

    public override string ToString()
    {
        return $"{Data} [{SubNodes.Count}] ({Prefix})";
    }

    public override bool Equals(object? obj)
    {
        if(obj is Node<T> item)
        {
            return Data.Equals(item);
        }
        else
        {
            return false; 
        }
    }
}
