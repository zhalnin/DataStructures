namespace LinkedList.Models;

internal class Item<T>
{
    private T data = default(T);

    public T Data
    {
        get => data;
        set => data = value ?? throw new ArgumentNullException(nameof(Data));
    }

    public Item<T> Next { get; set; }

    public Item(T data) =>
        Data = data;

    public override string ToString()
    {
        return Data.ToString();
    }
}
