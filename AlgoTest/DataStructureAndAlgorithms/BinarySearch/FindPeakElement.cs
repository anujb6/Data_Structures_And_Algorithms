using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class FindPeakElement
    {
        public static int FindpeakElement(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left + 1 < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                    right = mid;
                else
                    left = mid;
            }

            return nums[left] > nums[right] ? left : right;
        }
    }
}
