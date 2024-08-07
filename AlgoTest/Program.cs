﻿using AlgoTest.ds_algo.Arrays;
using AlgoTest.ds_algo.Binary_trees;
using AlgoTest.Models;

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
            new int[] {3, 7, 8},
            new int[] {9, 11, 13},
            new int[] {15, 16, 17}
        };

        var data = LuckyNumbersInAMatrix.LuckyNumbers(edges);

        int[] prices = { 0, 1, 5, 10, 14 };
        int[] nums2 = { 2, 2 };

        string s1 = "aa", t = "aa";

        //head = [1,2,3,4], n = 2

        ListNode one = new(9);
        ListNode two = new(9);
        ListNode three = new(9);
        ListNode four = new(9);
        ListNode five = new(9);
        ListNode six = new(9);
        ListNode seven = new(9);
        
        ListNode eight = new(9);
        ListNode nine = new(9);
        ListNode ten = new(9);
        ListNode eleven = new(9);

        /*        ListNode six = new(2);
                ListNode seven = new(1);
                ListNode eight = new(5);*/

        one.next = two;
        two.next = three;
        three.next = four;
        four.next = five;
        five.next = six;
        six.next = seven;

        eight.next = nine;
        nine.next = ten;
        ten.next = eleven;
       

        
        int[] nums1 = { 1, 2, 1, 0, 4, 2, 6 };
        int k = 3;

        int[][] customers = new int[][]
        {
            new int[] {20, 15, 1},
            new int[] {20, 17, 0},
            new int[] {50, 20, 1},
            new int[] {50, 80, 0},
            new int[] {80, 19, 1}
        };

        string[] logs = { "d1/", "d2/", "./", "d3/", "../", "d31/" };

        //Hello this a commit in develop branch


    }
}
