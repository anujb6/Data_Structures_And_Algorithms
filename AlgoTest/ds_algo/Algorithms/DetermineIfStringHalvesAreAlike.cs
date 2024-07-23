using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class DetermineIfStringHalvesAreAlike
    {
        public static bool HalvesAreAlike(string s)
        {
            HashSet<char> store = new(new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            int len = (s.Length) / 2, s1Count=0, s2Count=0;

            foreach (var (c1, c2) in s[0..len].Zip(s[len..(s.Length)]))
            {
                if (store.Contains(c1))
                    s1Count++;
                if(store.Contains(c2))
                    s2Count++;
            }

            return s1Count == s2Count;
        }
    }
}
