using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class HandOfStraights
    {
        public static bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
            {
                return false;
            }

            Dictionary<int, int> numsDict = new();

            foreach (int num in hand)
            {
                numsDict.TryAdd(num, 0);
                numsDict[num]++;
            }

            Array.Sort(hand);

            foreach (int num in hand)
            {
                if (numsDict[num] > 0)
                {
                    for (int i = num; i < num + groupSize; i++)
                    {
                        if (numsDict.ContainsKey(i) && numsDict[i] > 0)
                        {
                            numsDict[i]--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
