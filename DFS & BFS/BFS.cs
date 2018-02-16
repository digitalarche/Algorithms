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
        bool[] visited = new bool[graph.VerticesAmount];
        Queue<int> queue = new Queue<int>();

        visited[source] = true;
        queue.Enqueue(source);

        while (queue.Count != 0)
        {
            source = queue.Dequeue();
            Console.WriteLine("Next-> " + source);

            foreach (int next in graph.VerticesEdges[source])
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