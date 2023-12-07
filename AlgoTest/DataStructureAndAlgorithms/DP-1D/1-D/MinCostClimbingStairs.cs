using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D
{
    public class MinCostClimbingStairs
    {
        public int MinCostClimbingStair(int[] cost)
        {
            for (int i = 2; i < cost.Length; i++)
            {
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            }

            return Math.Min(cost[cost.Length - 1], cost[cost.Length - 2]);
        }
    }
}
