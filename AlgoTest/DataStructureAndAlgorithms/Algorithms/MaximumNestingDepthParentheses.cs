using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MaximumNestingDepthParentheses
    {
        public static int MaxDepth(string s)
        {
            if (s.Length == 1)
                return 0;

            int openParenthesis = 0;
            List<int> depths = new();

            foreach (char i in s)
            {
                if (i == '(')
                {
                    openParenthesis++;
                }
                else if (i == ')')
                {
                    depths.Add(openParenthesis);
                    openParenthesis--;
                }
            }

            return depths.Count > 0 ? depths.Max() : 0;
        }
    }
}

