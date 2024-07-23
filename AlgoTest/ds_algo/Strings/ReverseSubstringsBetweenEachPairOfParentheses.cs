using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Strings
{
    public class ReverseSubstringsBetweenEachPairOfParentheses
    {
        public static string ReverseParentheses(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            List<(int, int)> bracketPositions = new();
            while (i < j)
            {
                if (s[i] != '(')
                    i++;
                else
                {
                    while (s[j] != ')')
                    {
                        j--;
                    }

                    bracketPositions.Add((i, j));

                    i++;
                    j--;
                }
            }

            string tempReversedString = "";

            for (int k = bracketPositions.Count - 1; k >= 0; k--)
            {
                string sliced = s[(bracketPositions[k].Item1)..(bracketPositions[k].Item2 + 1)];
                sliced = sliced.Replace("(", "").Replace(")", "");

                if (tempReversedString.Length > 0)
                {
                    string prev = s[(bracketPositions[k + 1].Item1)..(bracketPositions[k + 1].Item2 + 1)].Replace("(", "").Replace(")", "");
                    sliced = sliced.Replace(prev, tempReversedString);
                }

                char[] arr = sliced.ToCharArray();
                Array.Reverse(arr);
                tempReversedString = new string(arr);
            }

            return tempReversedString;

        }
    }
}
