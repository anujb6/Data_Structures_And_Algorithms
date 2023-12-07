using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class TransitiveClosureOfGraph
    {
        public static int[,] TransitiveClosure(List<List<int>> graph)
        {
            int[,] copy = new int[graph.Count, graph[0].Count];

            var adjList = BuildGraphFromMatrix.BuildGraph(graph);

            static bool DFS(Dictionary<int, List<int>> adjList, int source, int destination, bool[] visited)
            {
                Stack<int> stack = new(new[] { source });
                visited[source] = true;

                while (stack.Count > 0)
                {
                    var curr = stack.Pop();

                    if (curr == destination)
                        return true;

                    foreach (var neighbour in adjList[curr])
                    {
                        if (!visited[neighbour])
                        {
                            stack.Push(neighbour);
                            visited[neighbour] = true;
                        }
                    }
                }

                return false;
            }

            for (var i = 0; i < graph.Count; i++)
            {
                for (var j = 0; j < graph[0].Count; j++)
                {
                    bool[] visited = new bool[graph.Count];
                    copy[i, j] = DFS(adjList, i, j, visited) ? 1 : 0;
                }
            }

            return copy;
        }
    }
}
