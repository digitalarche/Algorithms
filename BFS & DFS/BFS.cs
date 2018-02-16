using System;
using System.Collections.Generic;

public class BFS
{
    #region Members
    public Graph graph { get; set; }
    #endregion

    #region Constructor
    public BFS(Graph graph)
    {
        this.graph = graph;
    }
    #endregion

    #region Public Methods
    public void ExecuteAlgorithm(int source)
    {
        bool[] visited = new bool[graph.Vertices];

        Queue<int> queue = new Queue<int>();
        visited[source] = true;
        queue.Enqueue(source);

        while (queue.Count != 0)
        {
            source = queue.Dequeue();
            Console.WriteLine("next->" + source);

            foreach (Int32 next in graph.adj[source])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    queue.Enqueue(next);
                }
            }
        }
    }
    #endregion
}