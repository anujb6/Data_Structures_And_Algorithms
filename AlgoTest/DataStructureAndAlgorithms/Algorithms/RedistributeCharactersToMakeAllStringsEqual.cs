using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class RedistributeCharactersToMakeAllStringsEqual
    {
        public static bool MakeEqual(string[] words)
        {
            Dictionary<char, int> map = new();

            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (map.ContainsKey(c))
                        map[c]++;
                    else
                        map[c] = 1;
                }
            }

            List<int> hash = map.Values.ToList();

            foreach(var val in hash)
            {
                if (val % words.Length != 0)
                    return false;
            }

            return true;
        }
    }
}
