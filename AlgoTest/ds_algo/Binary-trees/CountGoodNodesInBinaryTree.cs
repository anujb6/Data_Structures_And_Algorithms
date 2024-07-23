using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class CountGoodNodesInBinaryTree
    {
        public static int GoodNodes(TreeNode root)
        {
            var count = 0;
            void preorder(TreeNode root, int max)
            {
                if (root == null)
                    return;

                if (root.val >= max)
                {
                    count++;
                    max = root.val;
                }

                preorder(root.left, max);
                preorder(root.right, max);
            }

            preorder(root, root.val);
            return count;
        }
    }
}
