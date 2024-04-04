using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class RangeSumOfBST
    {
        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            int sum = 0;

            static void dfs(TreeNode root, int low, int high, ref int sum)
            {
                if (root == null) return;

                if (root.val >= low && root.val <= high)
                    sum += root.val;

                dfs(root.left, low, high, ref sum);
                dfs(root.right, low, high, ref sum);
            }

            dfs(root, low, high, ref sum);
            return sum;
        } 
    }
}

