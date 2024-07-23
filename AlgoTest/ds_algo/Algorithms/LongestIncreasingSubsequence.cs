using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class LongestIncreasingSubsequence
    {
        public static int LengthOfLIS(int[] nums)
        {
            int maxSub = 0;

            for(int i=0; i<nums.Length; i++)
            {
                int count = 0; 
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[j] >= nums[i])
                        count++;
                }

                maxSub = Math.Max(maxSub, count);
            }

            return maxSub;
        }
    }
}
