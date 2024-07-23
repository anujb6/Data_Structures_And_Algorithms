using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.strings
{
    public class LongestPalindrome
    {
        public static int LongestPalindromes(string s)
        {
            Dictionary<Char, int> map = new();
            int count = 0;
            foreach(char c in s)
            {
                if (map.ContainsKey(c))
                    map[c] += 1;
                else
                    map[c] = 1;
            }

            int count1 = 0;
            foreach(var value in map.Values)
            {
                if(value % 2 == 0)
                {
                    count += value;
                }

                if(value == 1 && count1 < 1)
                {
                    count++;
                    count1++;
                }

            }

            return count;
        }
    }
}
