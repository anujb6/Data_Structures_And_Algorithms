using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Backtracking;
using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using AlgoTest.DataStructureAndAlgorithms.BitManipulation;
using AlgoTest.DataStructureAndAlgorithms.DP._2_D;
using AlgoTest.DataStructureAndAlgorithms.DP_1D;
using AlgoTest.DataStructureAndAlgorithms.DP_1D._2_D;
using AlgoTest.DataStructureAndAlgorithms.Graphs;
using AlgoTest.DataStructureAndAlgorithms.Graphs.Level2;
using AlgoTest.DataStructureAndAlgorithms.Intervals;
using AlgoTest.DataStructureAndAlgorithms.Linked_List;
using AlgoTest.DataStructureAndAlgorithms.MonotonicStack;
using AlgoTest.DataStructureAndAlgorithms.Trie;
using AlgoTest.Models;
using AlgoTest.ProjectEuler;
using AlgoTest.Structures;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 3 };
        int[] word1 = { 2 };
        int[][] word2 = { new[] { 3, 3, 0 }, new[] { 1, 2, 0 }, new[] { 0, 3, 1 }, new[] { 0, 3, 2 }, new[] { 0, 4, 1 }}; 
        TreeNode a = new(2);
        a.left = new TreeNode(2);
        a.right = new TreeNode(5);
        a.right.left = new TreeNode(5);
        a.right.right = new TreeNode(7);

        IList<IList<string>> paths = new List<IList<string>>
        {
            new List<string> { "London", "New York" },
            new List<string> { "New York", "Lima" },
            new List<string> { "Lima", "Sao Paulo" }
        };

        List<string> directions = new()
        {
            "0100",
            "10",
            "1111",
            "10010100"
        };
/*        foreach(var path in directions)
        {*/
            var data = TheLatestTimeToCatchABus.LatestTimeCatchTheBus(nums, word1, 1);
            Console.WriteLine(data);
/*        }*/
    }
}
