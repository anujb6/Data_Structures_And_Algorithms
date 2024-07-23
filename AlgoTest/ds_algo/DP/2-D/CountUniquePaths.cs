using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D._2_D
{
    public class CountUniquePaths
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] map = new int[m, n];

            for (int i=0; i<m; i++)
            {
                for(int j=0; j < n; j++)
                {
                    map[i,j] = 1;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    map[i, j] = map[i-1,j] + map[i, j - 1];
                }
            }

            return map[m - 1, n - 1];

        }
    }
}
