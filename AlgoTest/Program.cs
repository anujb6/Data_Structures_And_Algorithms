using AlgoTest.DataStructureAndAlgorithms.Algorithms;
using AlgoTest.DataStructureAndAlgorithms.Arrays;
using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using AlgoTest.DataStructureAndAlgorithms.BinarySearch;
using AlgoTest.DataStructureAndAlgorithms.Stack;
using AlgoTest.Structures;

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

        //root = [1,null,2,null,3,null,4,null,null]
        TreeNode a = new(1);
        a.right = new(2);
        a.right.right = new(3);
        a.right.right.right = new(4);
        a.right.right.right.right = new(5);

        TreeNode b = new(2500);
        b.left = new(5000);
        b.right = new(7500);
        b.right.right = new(10000);
        b.right.right.right = new(12500);
        b.left.right = new(15000);
        b.left.right.right = new (17500);

        int[] piles = { 25, 10, 23, 4 };
        int h = 4;

        // find the maximum
        // define left and right
        // keep a variable min to keep track of hours 
        // use while loop to loop through left to right
        // inside while loop use mid to loop through piles and calculate the hours
        // after loop is finished check if min is small or bigger


        int left = 1;
        int right = piles.Max();
        int minSpeed = right;


        while(left < right)
        {
            int mid = (left + right) / 2;
            int hoursTaken = 0;

            foreach (var pile in piles)
            {
                hoursTaken += (int)Math.Ceiling((double)pile / mid); 
            }

            if (hoursTaken <= h)
            {
                minSpeed = mid;
                right = mid - 1;
            }
            else
                left = mid + 1;
        }

        Console.WriteLine(minSpeed);

    }
}
