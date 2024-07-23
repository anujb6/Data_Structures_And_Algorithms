using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int max = 0;

            for(int i=0; i<height.Length; i++)
            {
                for(int j=i+1; j< height.Length; j++)
                {
                    var min = Math.Min(height[i], height[j]);
                    max = Math.Max(max, min * (j - i));

                }
            }

            return max;
        }
    }
}
