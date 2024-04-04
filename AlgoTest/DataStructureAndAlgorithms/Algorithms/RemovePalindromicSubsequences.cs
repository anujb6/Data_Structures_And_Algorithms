using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class RemovePalindromicSubsequences
    {
        public static int RemovePalindromeSub(string s)
        {
            if(s.Length == 0) return 0;

            var charArr = s.ToCharArray();
            Array.Reverse(charArr);
            var reverse = new string(charArr);
            if (s.Equals(reverse))
                return 1;

            return 2;
        }
    }
}
