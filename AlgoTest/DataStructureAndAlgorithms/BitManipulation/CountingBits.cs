using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BitManipulation
{
    public class CountingBits
    {
        public static int[] CountBits(int n)
        {
            List<int> res = new();
            for (int i = 0; i <= n; i++)
            {
                string? binary = Convert.ToString(i, 2);
                int count = binary.Count(x => x == '1');
                res.Add(count);
            }

            return res.ToArray();
        }
    }
}
