using System;

namespace MosheBinieli.Depth_First_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(4);

            AddEdgesToGrapg(graph);
            graph.PrintAdjacecnyMatrix();

            Console.WriteLine("BFS traversal starting from vertex 2:");
            BFS bfs = new BFS(graph);
            bfs.ExecuteAlgorithm(2);

            Console.WriteLine("DFS traversal starting from vertex 2:");
            DFS dfs = new DFS(graph);
            dfs.ExecuteAlgorithm(2);
        }

        private static void AddEdgesToGrapg(Graph graph)
        {
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
        }
    }
}
