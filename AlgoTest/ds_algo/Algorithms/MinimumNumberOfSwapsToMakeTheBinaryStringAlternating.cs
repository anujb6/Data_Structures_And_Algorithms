using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumNumberOfSwapsToMakeTheBinaryStringAlternating
    {
        public static int MinSwaps(string s)
        {
            var ones = 0;
            var zeros = 0;

            foreach(var letter in s)
            {
                if (letter == '1')
                    ones++;
                else
                    zeros++;
            }

            if (Math.Abs(ones - zeros) > 1)
                return -1;
            else if (ones > zeros)
                return CheckSwaps(s, '1');
            else if (zeros > ones)
                return CheckSwaps(s, '0');
            else
                return Math.Min(CheckSwaps(s, '1'), CheckSwaps(s, '0'));
        }

        public static int CheckSwaps(string s, char c)
        {
            int swaps = 0;
            for(int i=0; i<s.Length; i=i+2)
            {
                if(s[i] != c)
                    swaps++;
            }
            return swaps;
        }
    }
}
