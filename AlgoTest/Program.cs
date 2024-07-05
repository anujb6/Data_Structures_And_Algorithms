using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using AlgoTest.DataStructureAndAlgorithms.BinarySearch;
using AlgoTest.DataStructureAndAlgorithms.Graphs;
using AlgoTest.DataStructureAndAlgorithms.Graphs.Level1;
using AlgoTest.DataStructureAndAlgorithms.Linked_List;
using AlgoTest.DataStructureAndAlgorithms.Stack;
using AlgoTest.Models;
using AlgoTest.Structures;
using System.Data;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nums = { "Mary", "John", "Emma" };
        int[] word1 = { 7, 4, 3, 9, 1, 8, 5, 2, 6 };

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

        int[] a1 = { 28, 6, 22, 8, 44, 17 };
        int[] a2 = { 22, 28, 8, 6 };

        char[][] board = new char[][]
        {
            new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
            new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
            new char[] { '.', '9', '1', '.', '.', '.', '.', '.', '3' },
            new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
            new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        string[] s = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };

        int[] heights = { 4, 2, 3 }, speed = { 2, 2, 1, 1 }, worker = { 92, 10, 85, 84, 82 };

        List<List<int>> arr = new List<List<int>>() { 
            new() { 1, 1, 1, 0, 0, 0 },
            new() { 0, 1, 0, 0, 0, 0 },
            new() { 1, 1, 1, 0, 0, 0 },
            new() { 0, 0, 2, 4, 4, 0 },
            new() { 0, 0, 0, 2, 0, 0 },
            new() { 0, 0, 1, 2, 4, 0 },

        };

        int[][] edges = new int[][]{
            new int[] {0, 1},
            new int[] {1, 2},
            new int[] {2, 3},
            new int[] {0, 2},
            new int[] {1, 3},
            new int[] {2, 4},
        };

        int[] prices = { 0, 1, 5, 10, 14 };
        int[] nums2 = { 2, 2 };

        string s1 = "aa", t = "aa";

        ListNode head = new(0);
        ListNode one = new(1);
        ListNode two = new(2);
        ListNode three = new(3);
        ListNode four = new(0);
        ListNode five = new(2);
        ListNode six = new(2);
        ListNode seven = new(0);

        head.next = one;
        one.next = two;
        two.next = three;/*
        three.next = four;
        four.next = five;
        five.next = six;
        six.next = seven;*/

        int[] nums1 = { 1, 2, 1, 0, 4, 2, 6 };
        int k = 3;

        /*var data = SlidingWindowMaximum.MaxSlidingWindow(nums1, k);*/

        List<ListNode> listReverse = new();

        ListNode curr = head;
        while (curr != null)
        {
            listReverse.Insert(0, curr);
            curr = curr.next;
        }

        for(int i=0; i<listReverse.Count-1; i++)
        {
            listReverse[i].next = listReverse[i + 1];
        }

    }
}
