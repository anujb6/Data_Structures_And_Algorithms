using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class AmountOfTimeForBinaryTreeToBeInfected
    {
        public static int AmountOfTime(TreeNode root, int start)
        {
            Dictionary<int, List<int>> adjList = new();
            HashSet<int> check = new(new[] { start });

            static void treeDfs(TreeNode root, ref Dictionary<int, List<int>> adjList)
            {
                if (root == null)
                    return;

                if (root.left != null)
                {
                    if (adjList.ContainsKey(root.val))
                        adjList[root.val].Add(root.left.val);
                    else
                        adjList[root.val] = new List<int>() { root.left.val };

                    if (adjList.ContainsKey(root.left.val))
                        adjList[root.left.val].Add(root.val);
                    else
                        adjList[root.left.val] = new List<int>() { root.val };
                }


                if (root.right != null)
                {
                    if (adjList.ContainsKey(root.val))
                        adjList[root.val].Add(root.right.val);
                    else
                        adjList[root.val] = new List<int>() { root.right.val };


                    if (adjList.ContainsKey(root.right.val))
                        adjList[root.right.val].Add(root.val);
                    else
                        adjList[root.right.val] = new List<int>() { root.val };
                }

                treeDfs(root.right, ref adjList);
                treeDfs(root.left, ref adjList);
            }

            treeDfs(root, ref adjList);

            Stack<int> stack = new(new[] { start });
            int count = 0;
            while (stack.Count > 0)
            {
                var curr = stack.Pop();
                bool isInfected = false;
                if(adjList.ContainsKey(curr))
                    foreach (var neighbour in adjList[curr])
                    {
                        if(!check.Contains(neighbour))
                            stack.Push(neighbour);
                        if (!check.Contains(neighbour) && !isInfected)
                        {
                            count++;
                            isInfected = true;
                        }
                   
                        check.Add(neighbour);
                    }
            }

            return count;
        }
    }
}
