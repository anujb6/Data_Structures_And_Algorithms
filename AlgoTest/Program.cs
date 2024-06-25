using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.BinarySearch;
using AlgoTest.DataStructureAndAlgorithms.Stack;
using AlgoTest.Structures;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nums = { "Mary", "John", "Emma" };
        int[] word1 = { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
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

        int target = 10;
        List<List<int>> arr = new List<List<int>>() { 
            new() { 1, 1, 1, 0, 0, 0 },
            new() { 0, 1, 0, 0, 0, 0 },
            new() { 1, 1, 1, 0, 0, 0 },
            new() { 0, 0, 2, 4, 4, 0 },
            new() { 0, 0, 0, 2, 0, 0 },
            new() { 0, 0, 1, 2, 4, 0 },

        };

    /*    var data  = TrappingRainWater.Trap(heights);
        Console.Write(data);
*/
        int sum = 0;

        for (int i=0; i<arr.Count; i++)
        {
            for(int j=0; j < arr[i].Count; j++)
            {
                if (i+2 < arr.Count && j + 2 < arr[i].Count)
                    sum = Math.Max(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2], sum);
                else
                    break;
            }
        }

        Console.Write(sum);
    }
}
