using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class WateringPlantsII
    {
        public static int MinimumRefill(int[] plants, int capacityA, int capacityB)
        {
            int alice = 0;
            int bob = plants.Length - 1;
            int count = 0;
            int tempCapacityA = capacityA;
            int tempCapacityB = capacityB;

            while (alice <= bob)
            {

                if (alice == bob)
                {
                    int minWater = Math.Min(tempCapacityA, tempCapacityB);
                    if (minWater < plants[alice])
                        count++;

                    break;
                }


                if (plants[alice] > tempCapacityA)
                {
                    count++;
                    tempCapacityA = capacityA - plants[alice];
                }
                else
                {
                    tempCapacityA -= plants[alice];
                }
                if (plants[bob] > tempCapacityB)
                {
                    count++;
                    tempCapacityB = capacityB - plants[b];
                }
                else
                {
                    tempCapacityB -= plants[b];
                }

            }

            return count;
        }
    }
}
