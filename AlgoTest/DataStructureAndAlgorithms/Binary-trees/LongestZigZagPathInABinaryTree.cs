using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class LongestZigZagPathInABinaryTree
    {
        private static List<int> zags = new();
        private static void rightZigZag(TreeNode root, int count)
        {
            var stack = new List<TreeNode>() { root };
            var nodepos = 1;

            while (stack.Count > 0)
            {
                TreeNode curr = stack.LastOrDefault();
                stack.RemoveAt(stack.Count - 1);

                Console.WriteLine(curr.val);

                if (nodepos % 2 == 0 && curr.left != null)
                {
                    stack.Add(curr.left);
                    count++;
                    nodepos++;
                }
                else if (nodepos % 2 != 0 && curr.right != null)
                {
                    stack.Add(curr.right);
                    count++;
                    nodepos++;
                }
                else
                {
                    break;
                }
            }

            zags.Add(count);
        }

        private static void leftZigZag(TreeNode root, int count)
        {
            var stack = new List<TreeNode>() { root };
            var nodepos = 1;

            while (stack.Count > 0)
            {
                TreeNode curr = stack.LastOrDefault();
                stack.RemoveAt(stack.Count - 1);

                Console.WriteLine(curr.val);

                if (nodepos % 2 == 0 && curr.right != null)
                {
                    stack.Add(curr.right);
                    count++;
                    nodepos++;
                }
                else if (nodepos % 2 != 0 && curr.left != null)
                {
                    stack.Add(curr.left);
                    count++;
                    nodepos++;
                }
                else
                {
                    break;
                }
            }

            zags.Add(count);
        }

        static void preorder(TreeNode root)
        {
            if (root == null)
                return;

            rightZigZag(root, 0);
            leftZigZag(root, 0);
            preorder(root.left);
            preorder(root.right);
        }

        static int LongestZigZagPath(TreeNode root)
        {
            preorder(root);
            return zags.Max();
        }
    }
}
