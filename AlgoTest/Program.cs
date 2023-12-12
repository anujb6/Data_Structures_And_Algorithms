using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Backtracking;
using AlgoTest.DataStructureAndAlgorithms.BitManipulation;
using AlgoTest.DataStructureAndAlgorithms.DP_1D;
using AlgoTest.DataStructureAndAlgorithms.DP_1D._2_D;
using AlgoTest.DataStructureAndAlgorithms.Graphs.Level2;
using AlgoTest.DataStructureAndAlgorithms.Intervals;
using AlgoTest.DataStructureAndAlgorithms.Linked_List;
using AlgoTest.DataStructureAndAlgorithms.MonotonicStack;
using AlgoTest.DataStructureAndAlgorithms.Trie;
using AlgoTest.Models;
using AlgoTest.ProjectEuler;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 5, 1, 2, 3, 4 };
        int[] word1 = { 3, 2, 4, 1, 5 };
        int[][] word2 = { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 }};
        var data = SearchA2DMatrix.SearchMatrix(word2, 13);
        Console.WriteLine(data);
    }
}
