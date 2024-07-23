using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoTest.DataStructureAndAlgorithms.Backtracking
{
    public class CombinationSumIII
    {
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> results = new();
            Stack<int> stack = new();
            recurse(1, k, n);
            return results;

            void recurse(int startingValue, int numberOfNumbers, int targetSum)
            {
                if (targetSum == 0 && numberOfNumbers == 0) 
                    results.Add(stack.ToArray());
                if (targetSum == 0 || numberOfNumbers == 0) 
                    return;

                for (int i = startingValue; i < 10; i++)
                {
                    stack.Push(i);
                    recurse(i + 1, numberOfNumbers - 1, targetSum - i);
                    stack.Pop();
                }
            }
        }
    }
}
