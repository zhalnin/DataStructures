﻿namespace Graph.Models;

internal sealed class Edge
{
    public Vertex From { get; set; }
    public Vertex To { get; set; }
    public bool Oriented { get; set; }
    public  int Weight { get; set; }

    public Edge(Vertex from, Vertex to, int weight = 1)
    {
        From = from; 
        To = to; 
        Weight = weight;
    }

    public override string ToString() =>
        $"({From}; {To})";
}