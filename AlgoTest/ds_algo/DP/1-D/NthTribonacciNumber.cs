using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D
{
    public class NthTribonacciNumber
    {
        public static int Tribonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            int first = 0;
            int second = 1;
            int third = 1;

            int next = 0;

            for (int i = 2; i < n; i++)
            {
                next = first + second + third;
                first = second;
                second = third;
                third = next;
            }

            return next;
        }
    }
}
