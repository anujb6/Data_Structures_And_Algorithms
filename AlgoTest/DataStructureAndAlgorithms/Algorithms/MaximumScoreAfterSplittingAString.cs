using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MaximumScoreAfterSplittingAString
    {
        public static int MaxScore(string s)
        {
            int zeroes = 0;
            int sum = 0;
            int ones = s.Count(x => x == '1');

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '0')
                    zeroes++;

                if (s[i] == '1')
                    ones--;

                sum = Math.Max(sum, zeroes + ones);
            }

            return sum;
        }
    }
}
