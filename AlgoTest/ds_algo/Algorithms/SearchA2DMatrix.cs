using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class SearchA2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            for(int i=0; i < matrix.Length; i++)
            {
                var lastEle = matrix[i][matrix[0].Length - 1];

                if (target > lastEle)
                    continue;
                else if (target == lastEle)
                    return true;
                else
                    foreach (var ele in matrix[i])
                    {
                        if (ele == target) return true;
                        else if (ele > target) break;
                    }
            }

            return false;
        }
    }
}
