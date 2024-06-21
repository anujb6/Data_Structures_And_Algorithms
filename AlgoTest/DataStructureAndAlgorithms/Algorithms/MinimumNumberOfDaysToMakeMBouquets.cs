using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumNumberOfDaysToMakeMBouquets
    {
        public static int MinDays(int[] bloomDay, int m, int k)
        {
           
            SortedSet<int> UniqueBloomDays = new(bloomDay);

            if (m * k > bloomDay.Length)
                return -1;


            foreach(int uniqueDay in UniqueBloomDays)
            {
                int count = 0;
                double bouquetCount = 0;

                for(int i=0; i<bloomDay.Length; i++)
                {

                    if (uniqueDay >= bloomDay[i])
                    {
                        count++;
                    }
                    else
                    {
                        bouquetCount += Math.Floor((double)count / k);
                        count = 0;
                    }
                }

                bouquetCount += Math.Floor((double)count / k);

                if (bouquetCount >= m)
                    return uniqueDay;
            }

            return -1;
            
        }
    }
}
