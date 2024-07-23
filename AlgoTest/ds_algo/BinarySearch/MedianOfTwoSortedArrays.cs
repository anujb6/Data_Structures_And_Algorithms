using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combinedArr = nums1.Concat(nums2).ToArray();
            Array.Sort(combinedArr);

            if (combinedArr.Length % 2 == 0)
            {
                int mid1 = (combinedArr.Length / 2) - 1;
                int mid2 = (combinedArr.Length / 2);
                return (double)(combinedArr[mid1] + combinedArr[mid2]) / 2;
            }
            else
            {
                int mid = (combinedArr.Length / 2);
                return (double)combinedArr[mid];
            }
        }
    }
}
