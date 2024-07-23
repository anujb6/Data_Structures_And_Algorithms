using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CanMakePalindromeFromSubstring
    {
        public static IList<bool> CanMakePaliQueries(string s, int[][] queries)
        {
            List<bool> response = new(); 
            foreach(var x in queries)
            {
                int start = x[0];
                int end = x[1];

                string str = s.Substring(start, end - start + 1);

                if (str.Length == 1)
                    response.Add(true);
                else
                    response.Add(CanConvertToPalindrome(str, x[2]));
            }

            return response;

            static bool CanConvertToPalindrome(string s, int n)
            {
                Dictionary<char, int> map = new();

                foreach (var c in s)
                {
                    if (map.ContainsKey(c))
                        map[c]++;
                    else
                        map[c] = 1;
                }

                var oddOccurrences = map.Values.Where(x => x % 2 != 0).Count();
                var oddRepairsAllowed = n * 2 + (s.Length % 2 == 1 ? 1 : 0);

                if (oddOccurrences <= oddRepairsAllowed)
                    return true;
                else
                    return false;

            }
        }
    }
}
