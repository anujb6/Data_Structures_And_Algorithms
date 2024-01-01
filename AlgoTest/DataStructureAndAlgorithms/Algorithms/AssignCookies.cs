using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            int count = 0;
            int j = 0, i=0;
            Array.Sort(g);
            Array.Sort(s);

            while(i < s.Length && j < g.Length)
            {
                var ith = s[i];
                var jth = g[j];
                if (ith >= jth)
                {
                    count++;
                    i++;
                    j++;
                }
                else
                    i++;
            }

            return count;
        }
    }
}
