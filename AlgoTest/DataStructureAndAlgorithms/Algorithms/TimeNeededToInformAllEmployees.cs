using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class TimeNeededToInformAllEmployees
    {
        public static int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, Dfs(i));
            }

            return ans;

            int Dfs(int i)
            {
                if (manager[i] == -1) 
                    return informTime[i];

                informTime[i] += Dfs(manager[i]);
                manager[i] = -1;
                return informTime[i];
            }
        }
    }
}
