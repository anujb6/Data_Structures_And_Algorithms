using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Intervals
{
    public class NonOverlappingIntervals
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            int count = 0;
            Array.Sort(intervals, (a, b) => { return a[1] - b[1]; });
            var prev = intervals[0][1];

            for(var i=1; i< intervals.Length; i++)
            {
                if (intervals[i][0] < prev)
                    count++;
                else
                    prev = intervals[i][1];
            }

            return count;
        }
    }
}
