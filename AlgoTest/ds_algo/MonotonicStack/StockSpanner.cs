using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.MonotonicStack
{
    public class StockSpanner
    {
        public static List<int> stockPrices;
        static StockSpanner()
        {
            stockPrices = new();
        }

        public static int Next(int price)
        {
            int count = 0;
            for (var i = stockPrices.Count - 1; i >= 0; i--)
            {
                count++;
                if (stockPrices[i] > price)
                    break;
            }

            stockPrices.Add(price);
            return count;
        }
    }
}
