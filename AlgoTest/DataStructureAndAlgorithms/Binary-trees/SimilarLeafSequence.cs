using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class SimilarLeafSequence
    {
        private static void postorder(TreeNode root, List<int> leafs)
        {
            if (root == null)
                return;

            postorder(root.left, leafs);
            postorder(root.right, leafs);

            if (root.left == null && root.right == null)
                leafs.Add(root.val);
        }

        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaf1 = new List<int>();
            var leaf2 = new List<int>();

            postorder(root1, leaf1);
            postorder(root2, leaf2);

            if (leaf1.Count == leaf2.Count)
            {
                foreach (var (node1, node2) in leaf1.Zip(leaf2))
                {
                    if (node1 != node2)
                        return false;
                }

                return true;
            }
            return false;
        }
    }
}
