using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Backtracking;
using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
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
        int[][] word2 = { new[] { 0, 1, 1 }, new[] { 1, 0, 1 }, new[] { 0, 0, 1 }  }; //[1,4],[2,4],[3,1],[3,2]
        Node a = new(1);
        a.left = new Node(2);
        a.left.left = new Node(4);
        a.left.right = new Node(5);
        a.right = new Node(3);
        a.right.left = new Node(6);
        a.right.right = new Node(7);

        var data = PopulatingNextRightPointersInEachNode.Connect(a);
        Console.WriteLine(data);
    }
}
