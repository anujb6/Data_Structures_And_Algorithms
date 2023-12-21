using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));

            int max = 0;

            for(var i=1; i<points.Length; i++)
            {
                max = Math.Max(max, points[i][0] - points[i-1][0]);
            }

            return max;
        }
    }
}
