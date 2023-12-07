using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.DP_1D._2_D
{
    public class EditDistance
    {
        public static int MinDistance(string word1, string word2)
        {
            int[,] map = new int[word2.Length+1, word1.Length+1];
            int x = map.GetLength(0);
            int y = map.GetLength(1);

            for (int i=1; i<y; i++)
            {
                map[0, i] = i;
            }
            for (int i=1; i<x; i++)
            {
                map[i, 0] = i;
            }

            for(int i=0; i<word2.Length; i++)
            {
                for(int j=0; j<word1.Length; j++)
                {
                    if (word2[i] == word1[j]) map[i + 1, j + 1] = map[i , j];
                    else
                    {
                        var first = Math.Min(map[i, j + 1], map[i + 1, j]);
                        var res = Math.Min(first, map[i, j]);
                        map[i+1, j+1] = res+1;
                    }

                }
            }
            return map[word2.Length, word1.Length];
        }
    }
}
