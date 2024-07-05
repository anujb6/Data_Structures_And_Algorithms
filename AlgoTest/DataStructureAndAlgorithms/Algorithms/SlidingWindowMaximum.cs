using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class SlidingWindowMaximum
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int right = k;
            List<int> result = new();

            for(int i=0; i<(nums.Length-k)+1; i++)
            {
                int[] window = nums[i..(i + right)];
                result.Add(window.Max());
            }

            return result.ToArray();
        }
    }
}
