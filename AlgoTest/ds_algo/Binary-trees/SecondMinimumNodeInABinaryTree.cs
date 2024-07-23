using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class SecondMinimumNodeInABinaryTree
    {
        public static int FindSecondMinimumValue(TreeNode root)
        {
            SortedSet<int> res = new();

            void Dfs(TreeNode root)
            {
                if (root == null)
                    return;

                res.Add(root.val);

                Dfs(root.left);
                Dfs(root.right);
            }

            Dfs(root);


           List<int> newRes = res.ToList();

            if (res.Count == 1 || newRes[0] == newRes[1])
                return -1;
            else
                return newRes[1];

        }
    }
}
