using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class PathSum3
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;

            return Dfs(root, targetSum)
                + PathSum(root.left, targetSum)
                + PathSum(root.right, targetSum);

            static int Dfs(TreeNode node, long sum)
            {
                var s = node.val == sum ? 1 : 0;

                if (node.left != null)
                    s += Dfs(node.left, sum - node.val);

                if (node.right != null)
                    s += Dfs(node.right, sum - node.val);

                return s;
            }
        }
    }
}
