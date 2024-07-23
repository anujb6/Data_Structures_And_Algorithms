using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumChangesToMakeAlternatingBinaryString
    {
        public int MinOperations(string s)
        {
            string baseOne = "10", baseTwo = "01";
            int diff1 = 0, diff2 = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != baseOne[i % 2])
                    diff1++;
                if (s[i] != baseTwo[i % 2])
                    diff2++;
            }

            return Math.Min(diff1, diff2);
        }
    }
}
