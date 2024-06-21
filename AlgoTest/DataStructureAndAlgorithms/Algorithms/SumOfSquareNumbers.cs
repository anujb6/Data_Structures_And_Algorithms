using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class SumOfSquareNumbers
    {
        public static bool JudegSqaureSum(int c)
        {
            int left = 0;
            int right = (int)Math.Sqrt(c);
            while(left <= right)
            {
                int num = left  * left + right * right;
                if (num == c)
                    return true;
                else if (num > c)
                    right--;
                else
                    left++;
            }

            return false;


        }
    }
}
