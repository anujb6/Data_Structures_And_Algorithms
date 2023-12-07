using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class RightViewOfBinaryTree
    {
        public static List<int> PrintRightView(TreeNode root)
        {
            var map = new Dictionary<int, List<int>>();
            var res = new List<int>();

            void preorder(TreeNode root, int level, Dictionary<int, List<int>> map)
            {
                if (root == null)
                    return;

                if (map.ContainsKey(level))
                    map[level].Add(root.val);
                else
                    map[level] = new List<int>() { root.val };

                preorder(root.left, level + 1, map);
                preorder(root.right, level + 1, map);
            }

            preorder(root, 0, map);
            foreach (var value in map.Values)
            {
                res.Add(value[value.Count - 1]);
            }

            return res;
        }
    }
}
