using System;
using System.Collections.Generic;

public class Graph
{
    #region Members
    public int Vertices;
    public List<Int32>[] adj;
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