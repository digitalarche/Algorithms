using System;
using System.Collections.Generic;

public class DFS
{
    #region Members
    public Graph graph { get; set; }
    #endregion

    #region Constructor
    public DFS(Graph graph)
    {
        this.graph = graph;
    }
    #endregion

    #region Public Methods
    public void ExecuteAlgorithm(int source)
    {
        bool[] visited = new bool[graph.Vertices];

        Stack<int> stack = new Stack<int>();
        visited[source] = true;
        stack.Push(source);

        while (stack.Count != 0)
        {
            source = stack.Pop();
            Console.WriteLine("next->" + source);
            foreach (int i in graph.adj[source])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    stack.Push(i);
                }
            }
        }
    }
    #endregion
}