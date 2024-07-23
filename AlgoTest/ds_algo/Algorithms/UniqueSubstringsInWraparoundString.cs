using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class UniqueSubstringsInWraparoundString
    {
        public static int FindSubstringInWrapaoundString(string s)
        {
            int[] count = new int[26];
            int res = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && (s[i - 1] + 1 == s[i] || (s[i - 1] == 'z' && s[i] == 'a')))
                    res++;
                else
                    res = 1;

                count[s[i] - 'a'] = Math.Max(count[s[i] - 'a'], res);
            }

            return count.ToList().Sum();
        }
    }
}
