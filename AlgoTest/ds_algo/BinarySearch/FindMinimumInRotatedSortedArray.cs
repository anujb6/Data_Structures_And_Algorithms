using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class FindMinimumInRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] <= nums[right])
                    return nums[left];

                int mid = (left + right) / 2;

                if (nums[mid] >= nums[left])
                    left = mid + 1;
                else
                    right = mid;
            }

            return 0;
        }
    }
}
