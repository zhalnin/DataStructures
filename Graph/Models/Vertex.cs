namespace Graph.Models;

internal sealed class Vertex
{
    public int Number { get; set; }

    public bool Visited { get; set; }

    public Vertex(int number) =>
        Number = number;

    public override string ToString() =>
        Number.ToString();
}