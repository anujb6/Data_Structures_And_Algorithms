using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class MaximumTotalImportanceOfRoads
    {
        public static long MaximumImportance(int n, int[][] roads)
        {
            Dictionary<int, int> map = new();

            foreach (int[] road in roads)
            {
                if (map.ContainsKey(road[0]))
                    map[road[0]]++;
                else
                    map[road[0]] = 1;

                if (map.ContainsKey(road[1]))
                    map[road[1]]++;
                else
                    map[road[1]] = 1;
            }

            var dic = map.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int sum = 0;
            foreach(int key in dic.Keys)
            {
                sum += dic[key] * n;
                n--;
            }

            return sum;
        }
    }
}
