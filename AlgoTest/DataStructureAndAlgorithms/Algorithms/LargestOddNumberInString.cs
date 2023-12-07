using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class LargestOddNumberInString
    {
        public static string LargestOddNumber(string num)
        {
            var odd = "";

            for(int i=num.Length-1; i>=0; i--)
            {
                if ((int)Char.GetNumericValue(num[i]) % 2 != 0)
                {
                    odd = num.Remove(i + 1);
                    break;
                }
            }

            return odd;
        }
    }
}
