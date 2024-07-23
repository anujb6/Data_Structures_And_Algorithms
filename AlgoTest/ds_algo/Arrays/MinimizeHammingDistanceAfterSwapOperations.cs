using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class MinimizeHammingDistanceAfterSwapOperations
    {
        public static int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps)
        {
            int hammingDist = 0;
            int n = source.Length;
            List<List<int>> adjList = new();

            for (int i = 0; i < n; i++)
            {
                adjList.Add(new());
            }

            foreach (var swap in allowedSwaps)
            {
                adjList[swap[0]].Add(swap[1]);
                adjList[swap[1]].Add(swap[0]);
            }

            HashSet<int> visited = new();

            for (int i = 0; i < n; i++)
            {
                if (visited.Contains(i))
                    continue;

                visited.Add(i);

                List<int> connected = new() { i };

                Dfs(adjList, i, visited, connected);

                Dictionary<int, int> digCnt = new();

                foreach (var ind in connected)
                {
                    if (!digCnt.ContainsKey(target[ind]))
                        digCnt.Add(target[ind], 0);

                    digCnt[target[ind]]++;
                }

                foreach (var ind in connected)
                {
                    if (!digCnt.ContainsKey(source[ind]) || digCnt[source[ind]] <= 0)
                    {
                        hammingDist++;
                        continue;
                    }

                    digCnt[source[ind]]--;
                }
            }

            return hammingDist;
        }

        private static void Dfs(List<List<int>> adjList, int node, HashSet<int> visited, List<int> connected)
        {
            foreach (var nd in adjList[node])
            {
                if (visited.Contains(nd))
                    continue;

                visited.Add(nd);
                connected.Add(nd);
                Dfs(adjList, nd, visited, connected);
            }
        }
    }
}
