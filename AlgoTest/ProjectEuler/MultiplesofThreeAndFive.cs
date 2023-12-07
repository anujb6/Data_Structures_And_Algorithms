using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.ProjectEuler
{
    public class MultiplesofThreeAndFive
    {
        public static int Multiples(int n)
        {
            return SumDivisibleBy(n, 3) + SumDivisibleBy(n, 5) - SumDivisibleBy(n, 15);
        }

        static int SumDivisibleBy(int target, int divisor)
        {
            target--;
            int numDivisible = target / divisor;
            return divisor * (numDivisible * (numDivisible + 1) / 2);
        }
    }
}
