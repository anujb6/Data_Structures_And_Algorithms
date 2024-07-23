using Dotnet.DesignPatterns.abstract_pattern.capitals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.ds_algo.Arrays
{
    public class LuckyNumbersInAMatrix
    {
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            List<(int, int)> minElements = new();
            List<int> result = new();
            int len = matrix.Length;

            for(int i=0; i<len; i++)
            {
                var min = matrix[i].Min();

                int index = Array.IndexOf(matrix[i], min); 
                minElements.Add((min, index));
            }


            for(int i=0; i<minElements.Count; i++)
            {
                var max = int.MinValue;
                for(int j=0; j<len; j++)
                {
                    var ele = matrix[j][minElements[i].Item2];
                    max = Math.Max(max, ele);
                }

                if (minElements[i].Item1 == max)
                    result.Add(max);
            }

            return result;
        }
    }
}
