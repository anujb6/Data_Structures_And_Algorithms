using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var sortedS = s.ToList();
            var sortedT = t.ToList();

            sortedS.Sort();
            sortedT.Sort();

            foreach(var (s1, s2) in sortedS.Zip(sortedT))
            {
                if(s1 != s2)
                    return false;
            }

            return true;
        }
    }
}
