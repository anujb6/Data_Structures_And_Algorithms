using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Backtracking
{
    public class LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            var dictionary = new Dictionary<char, string>() 
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            List<string> result = new();

            void recurse(int i, string currStr)
            {
                if(currStr.Length == digits.Length)
                {
                    result.Add(currStr);
                    return;
                }

                foreach(var c in dictionary[digits[i]])
                {
                    recurse(i+1, currStr+c);
                }
            }

            if (digits.Length > 0)
                recurse(0, "");

            return result;
        }
    }
}
