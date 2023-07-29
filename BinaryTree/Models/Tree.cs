using System.Collections;
using System.ComponentModel.Design;
using System.Security.AccessControl;

namespace BinaryTree.Models;

internal class Tree<T> where T : IComparable
{
    public Node<T>? Root { get; private set; }
    public int Count { get; private set; }

    public void Add(T data)
    {
        if (Root is null)
        {
            Root = new Node<T>(data);
            Count++;
            return;
        }

        Root.Add(data);
        Count++;
    }
    /// <summary>
    /// To copy
    /// </summary>
    /// <returns></returns>
    public List<T> PrefOrder()
    {
        if (Root is null) return new List<T>();
        return PrefOrder(Root);
    }

    private List<T> PrefOrder(Node<T> node)
    {
        var list = new List<T>();
        if(node != null)
        {
            list.Add(node.Data);
            if(node.Left != null)
            {
                list.AddRange(PrefOrder(node.Left));
            }
            if(node.Right != null)
            {
                list.AddRange(PrefOrder(node.Right));
            }
        }
        return list;
    }
    /// <summary>
    /// To remove
    /// </summary>
    /// <returns></returns>
    public List<T> PostOrder()
    {
        if(Root is null) return new List<T>();
        return PostOrder(Root);
    }

    private List<T> PostOrder(Node<T> node)
    {
        var list = new List<T>();
        if (node != null)
        {
            if (node.Left != null)
            {
                list.AddRange(PostOrder(node.Left));
            }
            if (node.Right != null)
            {
                list.AddRange(PostOrder(node.Right));
            }
            list.Add(node.Data);
        }
        return list;
    }
    /// <summary>
    /// To sort
    /// </summary>
    /// <returns></returns>
    public List<T> InOrder()
    {
        if (Root is null) return new List<T>();
        return InOrder(Root);   
    }

    private List<T> InOrder(Node<T> node)
    {
        var list = new List<T>();
        if(node != null)
        {
            if(node.Left != null)
            {
                list.AddRange(InOrder(node.Left));
            }
            list.Add(node.Data);
            if(node.Right != null)
            {
                list.AddRange(InOrder(node.Right));
            }
        }
        return list;
    }
}
