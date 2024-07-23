using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.ds_algo.Binary_trees
{
    public class CreateBinaryTreeFromDescriptions
    {
        public static TreeNode CreateBinaryTree(int[][] descriptions)
        {
            Dictionary<int, TreeNode> nodeMap = new();
            HashSet<int> childrenSet = new();

            foreach (var desc in descriptions)
            {
                int parent = desc[0], child = desc[1], isLeft = desc[2];

                if (!nodeMap.ContainsKey(parent))
                    nodeMap[parent] = new TreeNode(parent);
                if (!nodeMap.ContainsKey(child))
                    nodeMap[child] = new TreeNode(child);

                if (isLeft == 1)
                    nodeMap[parent].left = nodeMap[child];
                else
                    nodeMap[parent].right = nodeMap[child];

                childrenSet.Add(child);
            }

            TreeNode root = null;
            foreach (var node in nodeMap.Values)
            {
                if (!childrenSet.Contains(node.val))
                {
                    root = node;
                    break;
                }
            }

            return root;
        }
    }
}
