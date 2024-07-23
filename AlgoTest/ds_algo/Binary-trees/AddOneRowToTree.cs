using AlgoTest.DataStructureAndAlgorithms.Graphs.Level1;
using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class AddOneRowToTree
    {
        public static TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            TreeNode leftNode = new(val);
            TreeNode rightNode = new(val);

            BFS(root, leftNode, rightNode, 1, depth);

            return root;
        }

        static void BFS(TreeNode root, TreeNode leftNode, TreeNode rightNode, int level, int depth)
        {
            if (root == null)
                return;

            if(level == depth - 1)
            {
                TreeNode tempLeft = root.left;
                TreeNode tempRight = root.right;

                leftNode.left = tempLeft;
                rightNode.left = tempRight;

                root.left = leftNode;
                root.right = rightNode;
            }

            BFS(root.left, leftNode, rightNode, level+1, depth);
            BFS(root.right, leftNode, rightNode, level+1, depth);

        }
    }
}
