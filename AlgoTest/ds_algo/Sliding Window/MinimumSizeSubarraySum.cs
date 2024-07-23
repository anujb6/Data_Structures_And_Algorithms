using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Sliding_Window
{
    public class MinimumSizeSubarraySum
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;

            int minLength = int.MaxValue;
            int sum = 0;

            while(left < nums.Length)
            {
                if (sum < target && right < nums.Length)
                {
                    if (right < nums.Length)
                    {
                        sum += nums[right];
                        right++;
                    }
                }
                else if (sum >= target)
                {
                    minLength = Math.Min(minLength, right - left);
                    sum -= nums[left];
                    if (left <= nums.Length - 1)
                        left++;
                }
                else
                    break;
            }

            return minLength == int.MaxValue? 0: minLength;
        }
    }
}
