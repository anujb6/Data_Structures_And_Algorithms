using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class DifferenceBetweenOnesAndZerosInRowAndColumn
    {
        public static int[][] OnesMinusZeros(int[][] grid)
        {
            Dictionary<int, List<int>> rowSums = new();
            Dictionary<int, List<int>> colSums = new();
            int[][] result = grid.Select(row => new int[row.Length]).ToArray();
            
            for(int i=0; i<grid.Length; i++)
            {
                var zeroes = 0;
                var ones = 0;
                for(int j=0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                        zeroes++;
                    else
                        ones++;
                }

                rowSums.Add(i, new List<int> { ones, zeroes });
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    colSums.Add(j, ColumnCalculation(grid, j));
                }
                break;
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    result[i][j] = rowSums[i][0] + colSums[j][0] - rowSums[i][1] - colSums[j][1];
                }
            }

            return result;
        }



        static List<int> ColumnCalculation(int[][] matrix, int colIndex)
        {
            int zeroes = 0;
            int ones = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][colIndex] == 1)
                    ones++;
                else
                    zeroes++;
            }

            return new List<int>() { ones, zeroes };
        }
    }
}
