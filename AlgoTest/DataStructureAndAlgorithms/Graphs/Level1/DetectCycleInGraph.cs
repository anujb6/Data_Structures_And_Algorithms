using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class DetectCycleInGraph
    {
        public static bool DFS(Dictionary<int, List<int>> adjList, int source, int destination, bool[] visited)
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
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
