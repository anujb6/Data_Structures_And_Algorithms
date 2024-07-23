using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves
    {
        public static int MinDifference(int[] nums)
        {
            if (nums.Length <= 4)
                return 0;

            int n = nums.Length;
            Array.Sort(nums);

            int[] mins = {
            nums[n-1]-nums[3],
            nums[n-2]-nums[2],
            nums[n-3]-nums[1],
            nums[n-4]-nums[0]
            };

            return mins.Min();
        }
    }
}
