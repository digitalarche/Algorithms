using System;
using System.Collections.Generic;

public class Graph
{
    #region Members
    public int VerticesAmount;
    public List<int>[] VerticesEdges;
    #endregion

    #region Constructor
    public Graph(int newVerticesAmount)
    {
        VerticesAmount = newVerticesAmount;
        VerticesEdges = new List<int>[newVerticesAmount];

        for (int i = 0; i < newVerticesAmount; i++)
            VerticesEdges[i] = new List<int>();
    }
    #endregion

    #region Public Methods
    public void AddEdge(int source, int destination)
    {
        VerticesEdges[source].Add(destination);
    }

    public void PrintAdjacecnyMatrix()
    {
        for (int i = 0; i < VerticesAmount; i++)
        {
            Console.Write(i + " : [");
            string tempString = "";

            foreach (int vertices in VerticesEdges[i])
                tempString += (vertices + ",");

            tempString = tempString.Substring(0, tempString.Length - 1);
            tempString += "]";

            Console.Write(tempString);
            Console.WriteLine();
        }
    }
    #endregion
}