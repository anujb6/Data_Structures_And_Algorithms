using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.strings
{
    public class AppendCharactersToStringToMakeSubsequence
    {
        public static int AppendCharacters(string s, string t)
        {
            int sIndex = 0, tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {

                if (s[sIndex] == t[tIndex])
                {
                    tIndex++;
                }

                sIndex++;
            }

            return t.Length - tIndex;
        }
    }
}
