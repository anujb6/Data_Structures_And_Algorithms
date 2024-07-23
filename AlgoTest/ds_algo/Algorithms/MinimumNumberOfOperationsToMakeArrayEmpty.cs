using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumNumberOfOperationsToMakeArrayEmpty
    {
        public static int MinOperations(int[] nums)
        {
            Dictionary<int, int> map = new();
            int moves = 0;

            foreach (int i in nums)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;
            }


            foreach(var key in map.Keys)
            {
                if (map[key] < 2)
                    return -1;

                if (map[key] % 3 == 0)
                {
                    moves += map[key] / 3;
                    continue;          
                }

                if (map[key] % 3 == 1)
                {
                    moves += (map[key] - 4) / 3 + 2;
                    continue;
                }

                moves += (map[key] - 2 ) / 3 + 1;
            }

            return moves;
        }
    }
}
