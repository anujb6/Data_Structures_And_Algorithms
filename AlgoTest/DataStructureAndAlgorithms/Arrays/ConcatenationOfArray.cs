using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class ConcatenationOfArray
    {
        public static int[] GetConcatenation(int[] nums)
        {
            return nums.Concat((int[])nums.Clone()).ToArray();
        }
    }
}
