using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ClimbingStairs
    {
        private static readonly Dictionary<int, int> store = new();
        public static int ClimbStairs(int n)
        {
            if (n == 1 || n == 2)
                return n;
            else if (store.ContainsKey(n))
                return store[n];
            else
            {
                store[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
                return store[n];
            }
        }
    }
}
