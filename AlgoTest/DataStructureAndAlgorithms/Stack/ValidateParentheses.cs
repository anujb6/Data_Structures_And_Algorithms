using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class ValidateParentheses
    {
        public static bool IsValid(string s)
        {
            if (s.Length < 2)
                return false;

            Stack<char> stack = new();
            Dictionary<char, char> store = new()
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };

            foreach (char c in s)
            {
                if (!store.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        char bracket = stack.Pop();
                        if (store[c] != bracket)
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
