using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static AlgoTest.DataStructureAndAlgorithms.Heap.MaximumSubSequenceScore;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class MinimumIncrementToMakeArrayUnique
    {
        /*nums = [3,2,1,2,1,7]*/

        public static int MinIncrementForUnique(int[] nums)
        {
            Dictionary<int, int> map = new();
            int count = 0;

            foreach (int num in nums)
            {
                if(map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            for(int i=0; i<nums.Length; i++)
            {
                if (map[nums[i]] == 1)
                    continue;
                else
                {
                    while (!map.ContainsKey(nums[i]))
                    {
                        nums[i] = nums[i] + 1;
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
