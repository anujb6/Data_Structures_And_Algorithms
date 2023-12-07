using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level2
{
    public class FindTheOrderingOfTask
    {
        public static List<int> FindOrder(int numTasks, List<List<int>> prerequisites)
        {
            var adjList = new Dictionary<int, List<int>>();
            foreach (var task in prerequisites)
            {
                var a = task[0];
                var b = task[1];

                if(adjList.ContainsKey(b))
                    adjList[b].Add(a);
                else
                    adjList[b] = new List<int>() { a };
            }

            var res = new HashSet<int>();

            void dfs(Dictionary<int, List<int>> graph, int source)
            {
                Queue<int> queue = new(new[] { source });

                while (queue.Count > 0)
                {
                    var curr = queue.Dequeue();
                    res.Add(curr);

                    if (!graph.ContainsKey(curr))
                    {
                        continue;
                    }

                    foreach (var neighbour in adjList[curr])
                    {
                        queue.Enqueue(neighbour);
                    }
                }
            }

            dfs(adjList, adjList.Keys.First());

            return res.ToList();
        }
    }
}
