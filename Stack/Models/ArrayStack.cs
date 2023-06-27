namespace Stack.Models;

internal class ArrayStack<T>
{
    private int current;
    private int size = 10;
    public int MaxCount => items.Length;
    public int Count => current;
    T[] items;

    public ArrayStack(int size = 10)
    {
        items = new T[size];
        this.size = size;
    }

    public ArrayStack(T data, int size = 10) : this(size)
    {
        items[current++] = data;
    }

    public void Push(T data)
    {
        if (current >= size) throw new StackOverflowException("The stack is full");

        items[current++] = data;
    }

    public T Pop()
    {
        if (current < 0) throw new NullReferenceException("The stack is empty");

        var item = items[--current];
        return item;
    }

    public T Peek()
    {
        if (current < 0) throw new NullReferenceException("The stack is empty");

        var item = items[current - 1];
        return item;
    }
}
