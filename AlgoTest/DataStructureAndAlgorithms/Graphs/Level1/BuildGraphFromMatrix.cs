using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class BuildGraphFromMatrix
    {
        public static Dictionary<int, List<int>> BuildGraph(List<List<int>> matrix)
        {
            Dictionary<int, List<int>> adjList = new();

            for (var i = 0; i < matrix.Count; i++)
            {
                adjList[i] = new List<int>(); // Initialize an empty list for each node.

                for (var j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        adjList[i].Add(j);
                    }
                }
            }

            return adjList;
        }
    }
}
