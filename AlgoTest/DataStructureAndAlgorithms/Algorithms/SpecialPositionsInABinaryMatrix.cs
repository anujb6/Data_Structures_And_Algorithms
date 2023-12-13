using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class SpecialPositionsInABinaryMatrix
    {
        public static int NumSpecial(int[][] mat)
        {
            int count = 0;
            for(var i=0; i<mat.Length; i++)
            {
                for(var j=0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                        if(Check(mat[i], ExtractColumn(mat, j)))
                            count++;
                }
            }

            return count;
        }

       static bool Check(int[] row, List<int> column)
       {
            return row.Sum() == 1 && column.Sum() == 1;
       }

        static List<int> ExtractColumn(int[][] matrix, int colIndex)
        {
            List<int> col = new();

            for(int i=0; i<matrix.Length; i++)
            {
                col.Add(matrix[i][colIndex]);
            }

            return col;
        }
    }
}
