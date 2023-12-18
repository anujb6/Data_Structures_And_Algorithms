using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MaximumProductDifferenceBetweenTwoPairs
    {
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            int max1 = nums[0];
            int max2 = nums[1];
            int min1 = nums[^1];
            int min2 = nums[^2];

            return Math.Abs((max1 * max2) - (min1 * min2));
        }
    }
}
