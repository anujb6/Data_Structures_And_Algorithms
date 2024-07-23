using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class NoOfProvince
    {
        public static int FindCircleNum(int[][] isConnected)
        {
            var adjList = new Dictionary<int, List<int>>();

            for (var i = 0; i < isConnected.Count(); i++)
            {
                for (var j = 0; j < isConnected[0].Count(); j++)
                {
                    if (adjList.ContainsKey(i + 1) && isConnected[i][j] == 1)
                        adjList[i + 1].Add(j + 1);
                    else if (isConnected[i][j] == 1)
                        adjList.Add(i + 1, new List<int>() { j + 1 });

                }
            }

            var count = 0;

            void dfs(Dictionary<int, List<int>> graph, int source)
            {
                var stack = new List<int>() { source };
                var map = new HashSet<int>();

                while (stack.Count > 0)
                {
                    var curr = stack.Last();
                    stack.RemoveAt(stack.Count - 1);

                    if (map.Contains(curr))
                        continue;
                    else
                        map.Add(curr);

                    foreach (var neighbour in graph[curr])
                    {
                        stack.Add(neighbour);
                    }
                    count++;
                }
            }


            dfs(adjList, adjList.Keys.FirstOrDefault());
            return adjList.Keys.Count - (count - 1);
        }
    }
}
