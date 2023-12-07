using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D
{
    public class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Max();

            int[] maximumRobbed = new int[nums.Length];
            maximumRobbed[0] = nums[0];
            maximumRobbed[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                int loot = maximumRobbed[i - 2] + nums[i];
                int noLoot = maximumRobbed[i - 1];

                maximumRobbed[i] = Math.Max(loot, noLoot);
            }

            return maximumRobbed[nums.Length - 1];

        }
    }
}
