using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class PrintAdjacencyList
    {
        public static Dictionary<int, List<int>> PrintGraph(List<List<int>> edges)
        {
            Dictionary<int, List<int>> adjList = new();

            foreach (var edge in edges)
            {
                var a = edge[0];
                var b = edge[1];

                if (!adjList.ContainsKey(a))
                    adjList[a] = new List<int>();
                if (!adjList.ContainsKey(b))
                    adjList[b] = new List<int>();

                adjList[a].Add(b);
                adjList[b].Add(a);
            }

            foreach(var node in adjList.Keys) 
            {
                Console.WriteLine(node);
                foreach(var value in adjList[node])
                {
                    Console.Write(value + " ");
                }
            }

            return adjList;
        }
    }
}
