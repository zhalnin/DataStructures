namespace Graph.Models;

internal sealed class Graphe
{
    readonly List<Vertex> vertexes = new();
    readonly List<Edge> edges = new();

    public int VertexesCount => vertexes.Count;
    public int EdgesCount => edges.Count;

    public void AddVertex(Vertex vertex) =>
        vertexes.Add(vertex);

    public void CreateEdge(Vertex from, Vertex to)
    {
        var edge = new Edge(from, to);
        AddEdge(edge);
    }

    public void AddEdge(Edge edge) =>
        edges.Add(edge);

    public int[,] GetMatrix()
    {
        var matrix = new int[vertexes.Count, vertexes.Count];

        foreach (var edge in edges)
        {
            var row = edge.From.Number - 1;
            var column = edge.To.Number - 1;

            matrix[row, column] = edge.Weight;
        }

        return matrix;
    }

    public List<Vertex> GetVertexLists2(Vertex vertex)
    {
        var result = new List<Vertex>();
        foreach (var edge in edges)
        {
            if(edge.From == vertex)
            {
                result.Add(edge.To);
            }
        }
        return result;
    }
    
    public IEnumerable<Vertex> GetVertexLists(Vertex vertex)
    {
        foreach (var edge in edges)
        {
            if(edge.From == vertex)
            {
                yield return edge.To;
            }
        }
    }

    public bool Wave2(Vertex start, Vertex end)
    {
        List<Vertex> list = new()
        {
            start
        };

        start.Visited = true;
        while(list.Count > 0)
        {
            var vertex = list[0];
            list.RemoveAt(0);

            foreach (var v in GetVertexLists(vertex))
            {
                if(!v.Visited)
                {
                    list.Add(v);
                    v.Visited = true;
                    if (v.Equals(end)) return true;
                }
            }
        }
        return false;
    }

    public bool Wave(Vertex start, Vertex end)
    {
        var list = new List<Vertex>
        {
            start
        };

        for (int i = 0; i < list.Count; i++)
        {
            var vertex = list[i];
            foreach (var v in GetVertexLists(vertex))
            {
                if (!list.Contains(v))
                {
                    list.Add(v);
                    if (list.Contains(end)) return true;
                }
            }

        }

        return list.Contains(end);
    }

    public bool Deep(Vertex current, Vertex target, List<Vertex>? list = null)
    {
        list ??= new List<Vertex>();
        if (current.Equals(target)) return true;
        if(list.Contains(current)) return false;

        list.Add(current);

        foreach (var v in GetVertexLists(current))
        {
            if(!list.Contains(v))
            {
                var reached = Deep(v, target, list);
                if (reached) return true;
            }
        }
        return false;
    }
}