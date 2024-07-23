using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class NumberOfTimesBinaryStringIsPrefix_Aligned
    {
        public static int NumTimeAllBlue(int[] flips)
        {
            int[] ground = new int[flips.Length];
            Array.Clear(ground, 0, ground.Length);
            int count = 0;

            for(int i=0; i<flips.Length; i++)
            {
                ground[flips[i]-1] = 1;
                if (IsPrefixAligned(ground.Take(i + 1)))
                    count++;
            }
            return count;
        }

        static bool IsPrefixAligned(IEnumerable<int> arr)
        {
            return !arr.Any(x => x == 0); 
        }
    }
}
