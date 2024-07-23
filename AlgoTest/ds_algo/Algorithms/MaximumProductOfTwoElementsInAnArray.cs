using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MaximumProductOfTwoElementsInAnArray
    {
        public static int MaxProduct(int[] nums)
        {
            int max = 0;

            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    max = Math.Max(max, (nums[i]-1) * (nums[j]-1));  
                }
            }

            return max;

        }
    }
}
