using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CalculateMoneyInLeetcodeBank
    {
        public static int TotalMoney(int n)
        {
            var total = 0;
            var loopCount = Math.Ceiling((double)n / 7);
            
            List<List<int>> list = new();
            for(int i=1; i<=loopCount; i++)
            {
               for(var j=i; j<=i+7-1; j++)
               {
                    if (n == 0)
                        return total;
                    else
                        total += j;
                    n--;
               }
            }
            return 0;
        }
    }
}
