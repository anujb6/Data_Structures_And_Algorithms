using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level2
{
    public class NoOfIslands
    {
        private static readonly List<IList<int>> directions = new() {
                        new List<int> { 1, 0 },
                        new List<int> { -1, 0 },
                        new List<int> { 0, 1 },
                        new List<int> { 0, -1 },
                        new List<int> { 1, -1 },
                        new List<int> { 1, 1 },
                        new List<int> { -1, 1 },
                        new List<int> { -1, -1 }
                    };
        public static int CountIslands(List<List<int>> matrix)
        {
            int count = 0;

            for (var i = 0; i < matrix.Count; i++)
            {
                for(var j=0; j < matrix[0].Count; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        matrix[i][j] = 0;
                        count++;
                        Recurse(i, j, matrix);
                    }
                }
            }

            return count;
        }

        static bool Check(int i, int j, int rowLength, int colLength)
        {
            if (i < 0 || j < 0 || i > rowLength-1 || j > colLength-1)
                return false;
            return true;
        }

        static void Recurse(int i, int j, List<List<int>> matrix)
        {
            foreach(var dir in directions)
            {
                var row = i + dir[0];
                var col = j + dir[1];

                if (Check(row, col, matrix.Count, matrix[0].Count) && matrix[row][col] == 1)
                {
                    matrix[row][col] = 0;
                    Recurse(row, col, matrix);
                }
            }
        }
    }
}
