using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            int l = 0, r = height.Length - 1;
            int left = height[l], right = height[r];
            int res = 0;
            while (l < r)
            {
                if (left < right)
                {
                    l++;
                    left = Math.Max(left, height[l]);
                    res += left - height[l];
                }
                else
                {
                    r--;
                    right = Math.Max(right, height[r]);
                    res += right - height[r];
                }
            }

            return res;
        }
    }
}
