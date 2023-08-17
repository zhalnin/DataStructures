// See https://aka.ms/new-console-template for more information
using Graph.Models;

Console.WriteLine("Hello, graph!");

var graph = new Graphe();
var v1 = new Vertex(1);
var v2 = new Vertex(2);
var v3 = new Vertex(3);
var v4 = new Vertex(4);
var v5 = new Vertex(5);
var v6 = new Vertex(6);
var v7 = new Vertex(7);

graph.AddVertex(v1);
graph.AddVertex(v2);
graph.AddVertex(v3);
graph.AddVertex(v4);
graph.AddVertex(v5);
graph.AddVertex(v6);
graph.AddVertex(v7);

graph.CreateEdge(v1, v2);
graph.CreateEdge(v1, v3);
graph.CreateEdge(v3, v4);
graph.CreateEdge(v2, v5);
graph.CreateEdge(v2, v6);
graph.CreateEdge(v6, v5);
graph.CreateEdge(v5, v6);

GetMatrix(graph);

Console.WriteLine();
Console.WriteLine();

GetVertex(graph, v1);
GetVertex(graph, v2);
GetVertex(graph, v3);
GetVertex(graph, v4);
GetVertex(graph, v5);
GetVertex(graph, v6);
GetVertex(graph, v7);

Console.WriteLine(graph.Wave(v1,v5));
//Console.WriteLine(graph.Wave(v2,v4));

Console.WriteLine(graph.Wave2(v1,v5));
//Console.WriteLine(graph.Wave2(v2,v4));


Console.WriteLine(graph.Deep(v1, v5));
Console.WriteLine(graph.Deep(v1, v4));



static void GetVertex(Graphe graph, Vertex vertex)
{
    Console.Write($"From: {vertex.Number} To: ");
    foreach (var v in graph.GetVertexLists(vertex))
    {
        Console.Write($"{v.Number}, ");
    }
    Console.WriteLine();
}

static void GetMatrix(Graphe graph)
{
    var matrix = graph.GetMatrix();

    for (int i = 0; i < graph.VertexesCount && i == 0; i++)
    {
        Console.Write($"   |");
        for (int j = 0; j < graph.EdgesCount && i == 0; j++)
        {
            Console.Write($" {j + 1}");
        }
        Console.WriteLine();
        for (int j = 0; j < graph.EdgesCount && i == 0; j++)
        {
            if (j == 0)
            {
                Console.Write($"___|____");
            }
            else
            {
                Console.Write($"__");
            }
        }
        Console.WriteLine();
    }

    for (int i = 0; i < graph.VertexesCount; i++)
    {
        Console.Write($"{i + 1}  | ");

        for (int j = 0; j < graph.EdgesCount; j++)
        {
            Console.Write(matrix[i, j] + " ", Environment.NewLine);
        }
        Console.WriteLine();
    }
}