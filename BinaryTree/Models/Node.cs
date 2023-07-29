namespace BinaryTree.Models;

internal class Node<T> : IComparable<T>, IComparable where T : IComparable
{
    public T Data { get; set; }
    public Node<T> Left { get; private set; }
    public Node<T> Right { get; private set; }

    public Node(T data) =>
        Data = data;

    public Node(T data, Node<T> left, Node<T> right) =>
        (Data, Left, Right) = (data, left, right);


    public void Add(T data)
    {
        var node = new Node<T>(data);
        if(node.Data.CompareTo(Data) < 0)
        {
            if(Left is null)
            {
                Left = node;
            }
            else
            {
                Left.Add(data);
            }
        }
        else
        {
            if(Right is null)
            {
                Right = node;
            }
            else
            {
                Right.Add(data);
            }
        }
    }

    public int CompareTo(T? other)
    {
        if (other is Node<T> item)
        {
            return Data.CompareTo(item.Data);
        }
        else
        {
            throw new ArgumentException("The types are not equals");
        }
    }

    public int CompareTo(object? obj)
    {
        if (obj is Node<T> item)
        {
            return Data.CompareTo(item.Data);
        }
        else
        {
            throw new ArgumentException("The types are not equals");
        }
    }

    public override string ToString()
    {
        return $"Node: {Data.ToString()}";
    }
}
