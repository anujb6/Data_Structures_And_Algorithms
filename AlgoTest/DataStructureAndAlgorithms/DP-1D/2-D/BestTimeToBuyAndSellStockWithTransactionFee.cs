using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D._2_D
{
    public class BestTimeToBuyAndSellStockWithTransactionFee
    {
        public static int MaxProfit(int[] prices, int fee)
        {
            int[,] map = new int[prices.Length, 2];
            for(var i=0; i<prices.Length; i++)
            {
                for(var j=0; j<2; j++)
                {
                    map[i, j] = 0;
                }
            }

            map[0,0] = -(prices[0] + fee);

            for (var i = 1; i < prices.Length; i++)
            {
                map[i, 0] = Math.Max(map[i - 1, 0], map[i - 1, 1] - (prices[i] + fee));
                map[i, 1] = Math.Max(map[i - 1, 0] + prices[i], map[i - 1, 1]);
            }

            return map[prices.Length - 1, 1];
        }
    }
}
