using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BitManipulation
{
    public class MinimumFlipsToMakeaORbEqualtoc
    {
        public static int MinFlips(int a, int b, int c)
        {
            var aBits = Convert.ToString(a, 2).PadLeft(4, '0');
            var bBits = Convert.ToString(b, 2).PadLeft(4, '0');
            var cBits = Convert.ToString(c, 2).PadLeft(4, '0');

            int count = 0;

            for(var i=0; i<cBits.Length; i++)
            {
                if (cBits[i] == '1')
                {
                    if (aBits[i] == '0' && bBits[i] == '0')
                        count++;
                }
                else
                {
                    if (aBits[i] == '1' && bBits[i] == '1')
                        count += 2;
                }
            }

            return count;
        }
    }
}
