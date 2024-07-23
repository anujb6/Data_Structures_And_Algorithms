using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumCostToChangeTheFinalValueOfExpression
    {
        static int pos = 0;
        public static int MinOperationsToFlip(string expression)
        {
            Stack<TreeNode> stack = new();
            ReadExpressions(expression, stack);

            TreeNode root = stack.Pop();
            int[] res = dfs(root);

            return Math.Max(res[0], res[1]);
        }

        static int[] dfs(TreeNode node)
        {
            if (node.left == null || node.right == null)
            {
                int val = node.val - '0';
                return new int[] { val ^ 0, val ^ 1 };
            }
            int[] left = dfs(node.left);
            int[] right = dfs(node.right);

            if (node.val == '&')
            {
                int minCostForZero = Math.Min(left[0], right[0]);
                int minCostForOne = Math.Min(left[1] + right[1], 1 + Math.Min(left[1], right[1]));
                return new int[] { minCostForZero, minCostForOne };
            }
            else if (node.val == '|')
            {
                int minCostForZero = Math.Min(left[0] + right[0], 1 + Math.Min(left[0], right[0])); ;
                int minCostForOne = Math.Min(left[1], right[1]);
                return new int[] { minCostForZero, minCostForOne };
            }
            else
                return new int[] { };
        }

        private static void ReadExpressions(String expression, Stack<TreeNode> stack)
        {
            if (pos == expression.Length)
                return;

            char ch = expression[pos++];

            if (ch == '0' || ch == '1')
            {
                TreeNode node = new(ch);
                if (stack.Count == 0)
                    stack.Push(node);
                else
                    stack.Peek().right = node;
            }
            else if (ch == '(')
            {
                Stack<TreeNode> tempStack = new();
                ReadExpressions(expression, tempStack);

                if (stack.Count == 0)
                    stack.Push(tempStack.Pop());
                else
                    stack.Peek().right = tempStack.Pop();
            }
            else if (ch == ')')
                return;
            else
            {
                TreeNode node = new(ch);
                node.left = stack.Pop();
                stack.Push(node);
            }

            ReadExpressions(expression, stack);
        }
    }
}
