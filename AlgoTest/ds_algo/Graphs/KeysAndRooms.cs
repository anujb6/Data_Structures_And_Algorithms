using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class KeysAndRooms
    {
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var adjList = new Dictionary<int, List<int>>();

            foreach (var room in rooms)
            {
                adjList.Add(rooms.IndexOf(room), room.ToList());
            }

            static bool depthFirstTraversal(Dictionary<int, List<int>> graph, int source)
            {
                var stack = new List<int>() { source };
                var visited = new HashSet<int>();

                while (stack.Count > 0)
                {
                    var curr = stack.Last();
                    stack.RemoveAt(stack.Count - 1);

                    if (visited.Contains(curr))
                        continue;

                    visited.Add(curr);

                    foreach (var neighbour in graph[curr])
                    {
                        stack.Add(neighbour);
                    }
                }
                return visited.Count == graph.Count;
            }

            return depthFirstTraversal(adjList, adjList.Keys.FirstOrDefault());
        }
    }
}
