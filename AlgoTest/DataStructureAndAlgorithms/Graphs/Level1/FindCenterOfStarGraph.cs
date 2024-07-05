using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class FindCenterOfStarGraph
    {
        public static int FindCenter(int[][] edges)
        {
            Dictionary<int, int> map = new();
            foreach(int[] edge in edges)
            {
                if (map.ContainsKey(edge[0]))
                    map[edge[0]]++;
                else
                    map[edge[0]] = 1;

                if (map.ContainsKey(edge[1]))
                    map[edge[1]]++;
                else
                    map[edge[1]] = 1;
            }


            return map.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
