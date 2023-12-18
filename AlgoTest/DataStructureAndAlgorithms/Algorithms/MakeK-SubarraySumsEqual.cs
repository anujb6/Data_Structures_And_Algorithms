using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MakeK_SubarraySumsEqual
    {
        public long MakeSubKSumEqual(int[] arr, int k)
        {
            var g = GCD(k, arr.Length);

            var ans = 0L;
            for (var i = 0; i < g; i++)
            {
                var stripe = new List<int>();
                for (var j = i; j < arr.Length; j += g)
                {
                    stripe.Add(arr[j]);
                }

                stripe.Sort();
                var median = stripe[stripe.Count / 2];

                foreach (var val in stripe)
                {
                    ans += Math.Abs(median - val);
                }
            }

            return ans;
        }

        private int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a | b;
        }
    }
}
