using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class SeachInBinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            var stack = new List<TreeNode>() { root };

            while (stack.Count > 0)
            {
                var curr = stack.LastOrDefault();
                stack.RemoveAt(stack.Count - 1);

                if (curr.val == val)
                    return curr;

                if (curr.left != null)
                    stack.Add(curr.left);

                if (curr.right != null)
                    stack.Add(curr.right);
            }

            return null;
        }
    }
}
