using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class KRadiusSubarrayAverages
    {
        public static int[] GetAverages(int[] nums, int k)
        {
            List<int> res = new();

            for(int i=0; i< nums.Length; i++)
            {
                if (i - k >= 0 && i + k < nums.Length)
                {
                    int[] nums1 = nums[(i - k)..i];
                    int[] nums2 = nums[i..(i + k+1)];
                    int avg = (nums1.Sum() + nums2.Sum()) / (nums1.Length + nums2.Length);
                    res.Add(avg);
                }
                else
                    res.Add(-1);
            }

            return res.ToArray();
        }
    }
}
