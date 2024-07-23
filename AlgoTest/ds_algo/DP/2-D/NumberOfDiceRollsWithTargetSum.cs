using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP._2_D
{
    public class NumberOfDiceRollsWithTargetSum
    {
        public static int Recurse(int dice, int faces, int target, int[,] dp)  
        {
            
            if(target == 0 || dice == 0)
            {
                if (target == 0 && dice == 0)
                    return 1;

                return 0;
            }
            if (dp[dice,target] != 0)
                return dp[dice, target];

            int ans = 0;
            for(int i=1; i<=faces; i++)
            {
                if (target - i >= 0)
                    ans = (ans + Recurse(dice - 1, faces, target - i, dp)) % (int)(1e9 + 7);
            }

            dp[dice, target] = ans;
            return ans;
        }

        public static int NumRollsToTarget(int n, int k, int target)
        {
            /*int[,] dp = new int[n + 1, target + 1];
            return Recurse(n, k, target, dp);*/
            int MOD = (int)(1e9 + 7);

            int[] dp = new int[target + 1];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int[] temp = new int[target + 1];
                for (int j = 1; j <= k; j++)
                {
                    for (int t = j; t <= target; t++)
                    {
                        temp[t] = (temp[t] + dp[t - j]) % MOD;
                    }
                }
                Array.Copy(temp, 0, dp, 0, target + 1);
            }

            return dp[target];
        }
    }
}
