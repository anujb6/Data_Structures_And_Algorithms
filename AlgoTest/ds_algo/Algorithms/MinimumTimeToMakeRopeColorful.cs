using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumTimeToMakeRopeColorful
    {
        public static int MinCost(string colors, int[] neededTime)
        {
            int sum = 0;
            List<int> needed = neededTime.ToList();
            for(int i=1; i<colors.Length; i++)
            {
                char c1 = colors[i];
                char c2 = colors[i-1];
                if (c1 == c2)
                {
                    int index = 0;
                    
                    if (needed[i - 1] < needed[i])
                        index = i-1;
                    else 
                        index = i;

                    sum += needed[index];
                    colors = colors.Remove(index, 1);
                    needed.RemoveAt(index);
                    i--;
                }
            }

            return sum;
        }
    }
}
