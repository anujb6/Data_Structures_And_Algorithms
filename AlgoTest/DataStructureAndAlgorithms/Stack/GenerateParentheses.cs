using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class GenerateParentheses
    {
        public static List<string> GenerateParenthesis(int n)
        {
            List<string> result = new();

            void backtrack(int open, int close, string current)
            {
                if (open == n && close == n)
                {
                    result.Add(current);
                    return;
                }

                if (open < n)
                {
                    backtrack(open + 1, close, current + "(");
                }

                if (close < open)
                {
                    backtrack(open, close + 1, current + ")");
                }
            }

            backtrack(0, 0, "");

            return result;
        }
    }
}
