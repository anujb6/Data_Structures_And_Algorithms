using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Backtracking;
using AlgoTest.DataStructureAndAlgorithms.BitManipulation;
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

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 5, 1, 2, 3, 4 };
        int[] word1 = { 0, 1, 2, 4, 5, 7 };
        int[][] word2 = { new[] { 1, 0 }, new[] { 0, 1 } }; //[1,4],[2,4],[3,1],[3,2]
        var data = SummaryRange.SummaryRanges(word1);
        Console.WriteLine(data);
    }
}
