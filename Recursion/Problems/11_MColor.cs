public class MColorSolution
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="edges"></param>
    /// <param name="m">No of Colors</param>
    /// <param name="n">No of Edges</param>
    /// <returns></returns>
    public static bool GraphColoring(List<List<int>> edges, int m, int n)
    {
        var coloredEdges = new int[n];
        Array.Fill(coloredEdges, 0);

        return Solve(edges, coloredEdges.ToList(), 0, m);
    }

    private static bool Solve(List<List<int>> edges, List<int> coloredEdges, int currNode, int m)
    {
        if (currNode == coloredEdges.Count)
        {
            return true;
        }

        for (int i = 1; i <= m; i++)
        {
            if(IsSafeToColor(edges, coloredEdges, currNode, i))
            {
                coloredEdges[currNode] = i;
                if(Solve(edges, coloredEdges, currNode + 1, m))
                {
                    return true;
                }

                coloredEdges[currNode] = 0;
            }
        }

        return false;
    }

    private static bool IsSafeToColor(List<List<int>> edge, List<int> coloredEdges, int currNode, int targetColor)
    {
        var neighbors = GetNeighbors(edge, currNode);
        foreach(var neighbor in neighbors)
        {
            if(coloredEdges[neighbor] == targetColor)
            {
                return false;
            }
        }
        return true;
    }

    private static List<int> GetNeighbors(List<List<int>> edges, int currNode)
    {
        var neighbors = new List<int>();

        foreach (var e in edges)
        {
            int u = e[0];
            int v = e[1];

            if (u == currNode)
                neighbors.Add(v);
            else if (v == currNode)
                neighbors.Add(u);
        }

        return neighbors;
    }

}