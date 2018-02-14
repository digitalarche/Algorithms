using System;
using System.Collections.Generic;

public class Graph
{
    #region Members
    private int Vertices;
    private List<Int32>[] adj;
    #endregion


    #region Constructor
    public Graph(int v)
    {
        Vertices = v;
        adj = new List<Int32>[v];

        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<Int32>();
        }
    }
    #endregion

    #region Public Methods
    public void AddEdge(int source, int destination)
    {
        adj[source].Add(destination);
    }

    //Print BFS traversal
    //s-> start node
    //BFS uses queue as a base.
    public void BFS(int source)
    {
        bool[] visited = new bool[Vertices];

        //create queue for BFS
        Queue<int> queue = new Queue<int>();
        visited[source] = true;
        queue.Enqueue(source);

        //loop through all nodes in queue
        while (queue.Count != 0)
        {
            //Deque a vertex from queue and print it.
            source = queue.Dequeue();
            Console.WriteLine("next->" + source);

            //Get all adjacent vertices of s
            foreach (Int32 next in adj[source])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    queue.Enqueue(next);
                }
            }

        }
    }

    //DFS traversal 
    // DFS uses stack as a base.
    public void DFS(int source)
    {
        bool[] visited = new bool[Vertices];

        //For DFS use stack
        Stack<int> stack = new Stack<int>();
        visited[source] = true;
        stack.Push(source);

        while (stack.Count != 0)
        {
            source = stack.Pop();
            Console.WriteLine("next->" + source);
            foreach (int i in adj[source])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    stack.Push(i);
                }
            }
        }
    }

    public void PrintAdjacecnyMatrix()
    {
        for (int i = 0; i < Vertices; i++)
        {
            Console.Write(i + ":[");
            string s = "";

            foreach (var k in adj[i])
                s = s + (k + ",");

            s = s.Substring(0, s.Length - 1);
            s = s + "]";

            Console.Write(s);
            Console.WriteLine();
        }
    }
    #endregion
}