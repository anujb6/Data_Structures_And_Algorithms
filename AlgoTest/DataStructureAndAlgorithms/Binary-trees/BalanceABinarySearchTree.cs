using AlgoTest.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class BalanceABinarySearchTree
    {
        public static TreeNode BalanceBST(TreeNode root)
        {
            var nodeList = new List<TreeNode>();
            CollectNodes(root, nodeList);

            void CollectNodes(TreeNode node, List<TreeNode> nodeList)
            {
                if (node == null) return;
                CollectNodes(node.left, nodeList);
                nodeList.Add(node);
                CollectNodes(node.right, nodeList);
            }

            TreeNode BuildBalancedTree(List < TreeNode > nodeList, int start, int end)
            {
                if (start > end) return null;
                int mid = start + (end - start) / 2;
                TreeNode root = nodeList[mid];
                root.left = BuildBalancedTree(nodeList, start, mid - 1);
                root.right = BuildBalancedTree(nodeList, mid + 1, end);
                return root;
            }

            return BuildBalancedTree(nodeList, 0, nodeList.Count - 1);
        }

    }
}
