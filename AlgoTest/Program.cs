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
using AlgoTest.DataStructureAndAlgorithms.Sliding_Window;
using AlgoTest.DataStructureAndAlgorithms.strings;
using AlgoTest.DataStructureAndAlgorithms.Trie;
using AlgoTest.Models;
using AlgoTest.ProjectEuler;
using AlgoTest.Structures;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nums = { "Mary", "John", "Emma" };
        int[] word1 = { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
        //[1,3],[2,3],[3,6],[5,6],[5,7],[4,5],[4,8],[4,9],[10,4],[10,9]
        int[][] word2 = { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 6 }, new[] { 5, 6 }, new[] { 5, 7 }, new[] { 4, 5 }, new[] { 4, 8 }, new[] { 4, 9 }, new[] { 10, 4 }, new[] { 10, 9 } }; 
        TreeNode a = new(1);
        a.left = new(5);
        a.left.right = new(4);
        a.left.right.left = new(9);
        a.left.right.right = new(2);
        a.right = new(3);
        a.right.right = new(6);
        a.right.left = new(10);


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

        string s = "aadsfasf absbs bbab cadsfafs";
        List<string> dictionary = new () { "a", "b", "c" };

        var data = ReplaceWords.ReplaceWords1(dictionary, s);

        Console.WriteLine(data);
    }
}
