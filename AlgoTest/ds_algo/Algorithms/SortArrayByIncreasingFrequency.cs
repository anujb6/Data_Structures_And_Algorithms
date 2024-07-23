using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.ds_algo.Algorithms
{
    public class SortArrayByIncreasingFrequency
    {
        public int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> map = new();
            foreach(int num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            var OrderedMap = map.OrderBy(x => x.Value);
        }
    }
}
