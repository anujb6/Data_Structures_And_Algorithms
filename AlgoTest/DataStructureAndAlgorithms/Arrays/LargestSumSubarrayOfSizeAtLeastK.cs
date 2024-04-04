using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class LargestSumSubarrayOfSizeAtLeastK
    {
        public long maxSumWithK(long[] a, long n, long k)
        {
            long i = 0;
            long j = i + k;
            long max = 0;

            while (j < n)
            {
                max = Math.Max(max, a.Skip((int)i).Take((int)k).Sum());
                i++; j++;
            }

            return max;
        }
    }
}
