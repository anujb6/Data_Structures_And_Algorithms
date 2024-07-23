using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class BuyTwoChocolates
    {
        public static int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            if (money - (prices[0] + prices[1]) >= 0)
                return money-(prices[1] + prices[0]);
            else
                return money;
        }
    }
}
