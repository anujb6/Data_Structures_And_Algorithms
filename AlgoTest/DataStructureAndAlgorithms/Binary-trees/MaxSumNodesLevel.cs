using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public static class MaxSumNodesLevel
    {
        public static int GetMaxSumLevel(TreeNode root)
        {
            var dic = new Dictionary<int, int>();
            void preorder(TreeNode root, int level, Dictionary<int, int> dic)
            {
                if (root == null)
                    return;

                if (dic.ContainsKey(level))
                    dic[level] += root.val;
                else
                    dic[level] = root.val;

                preorder(root.left, level + 1, dic);
                preorder(root.right, level + 1, dic);
            }
            preorder(root, 1, dic);
            return dic.Keys.Where(x => dic[x] == dic.Values.Max()).FirstOrDefault();
        }
    }
}
