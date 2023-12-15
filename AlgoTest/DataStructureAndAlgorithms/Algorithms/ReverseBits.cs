using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ReverseBits
    {
        public static uint ReverseBit(uint n)
        {
            var binaryString = Convert.ToString(n, 2).PadLeft(32, '0');

            char[] charArray = binaryString.ToCharArray();
            Array.Reverse(charArray);

            string ReversedString = new(charArray);
            return(Convert.ToUInt32(ReversedString, 2));
        }
    }
}
