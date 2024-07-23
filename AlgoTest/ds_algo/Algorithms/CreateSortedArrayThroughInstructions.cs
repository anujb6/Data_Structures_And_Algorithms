using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CreateSortedArrayThroughInstructions
    {
        public static int CreateSortedArray(int[] instructions)
        {
            Dictionary<int, int> nums = new();
            int cost = 0;

            foreach (var instruction in instructions)
            {
                var max = 0;
                var min = 0;


                foreach (var num in nums.Keys)
                {
                    if (num < instruction)
                        min += nums[num];
                    else if(num > instruction)
                        max += nums[num];
                }

                if (nums.ContainsKey(instruction))
                    nums[instruction]++;
                else
                    nums[instruction] = 1;

                cost += Math.Min(max, min);
                min = 0;
                max = 0;
            }
  
            return cost;
        }
    }
}
