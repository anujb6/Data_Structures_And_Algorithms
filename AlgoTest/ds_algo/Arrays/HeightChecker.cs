using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class HeightChecker
    {
        public static int HeightChecker1(int[] heights)
        {
            int[] clone = (int[])heights.Clone();
            int count = 0;

            Array.Sort(heights);

            for(int i=0; i<heights.Length; i++)
            {
                if (heights[i] != clone[i])
                    count++;
            }

            return count;
        }
    }
}
