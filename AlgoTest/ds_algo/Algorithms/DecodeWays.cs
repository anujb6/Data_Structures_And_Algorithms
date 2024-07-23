using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            return Recurse(0, s);

            static int Recurse(int i, string s)
            {
                if (i >= s.Length)
                    return 1;
                else if (s[i] == '0')
                    return 0;
                else if (i == s.Length - 1)
                    return 1;
                else if (s[i] == '1' || (s[i] == '2' && (i + 1 < s.Length && s[i + 1] >= '0' && s[i + 1] <= '6')))
                    return Recurse(i + 1, s) + Recurse(i + 2, s);
                else
                    return Recurse(i + 1, s);
            }
        }
    }
}
