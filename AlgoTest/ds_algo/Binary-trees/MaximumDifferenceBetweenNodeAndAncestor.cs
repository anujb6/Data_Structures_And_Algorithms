using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class MaximumDifferenceBetweenNodeAndAncestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            Queue<(TreeNode node, int min, int max)> q = new ();

            q.Enqueue((root, root.val, root.val));

            int maxDiff = 0;

            while(q.Count > 0)
            {
                TreeNode node = q.Peek().node;
                int min = q.Peek().min;
                int max = q.Peek().max;

                maxDiff = Math.Max(max - min, maxDiff);

                q.Dequeue();
             
                if (node.left != null)
                    q.Enqueue((node.left, Math.Min(min, node.left.val), Math.Max(max, node.left.val)));
                if (node.right != null)
                    q.Enqueue((node.right, Math.Min(min, node.right.val), Math.Max(max, node.right.val)));
            }

            return maxDiff;
        }
    }
}
