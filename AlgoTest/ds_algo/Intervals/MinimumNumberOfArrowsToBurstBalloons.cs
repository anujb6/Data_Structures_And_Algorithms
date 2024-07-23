using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Intervals
{
    public class MinimumNumberOfArrowsToBurstBalloons
    {
        public static int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => { return a[0] - b[0]; });

            var last = points[0][1];
            var arrowHits = 1;

            for(var i=0; i<points.Length; i++)
            {
                if (points[i][0] > last)
                {
                    arrowHits++;
                    last = points[i][1];
                }
                else
                    last = Math.Min(points[i][1], last);
            }

            return arrowHits;
        }
    }
}
