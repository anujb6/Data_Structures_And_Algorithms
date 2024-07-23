using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CheckIfTwoStringsArrayAreEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string string1 = "";
            string string2 = "";

            int i = 0;

            while(true) 
            {
                if (i > word1.Length-1 && i > word2.Length-1)
                    break;
                string1 += i < word1.Length ? word1[i] : "";
                string2 += i < word2.Length ? word2[i] : "";
                i++;
            }

            return string1.Equals(string2);
        }
    }
}
