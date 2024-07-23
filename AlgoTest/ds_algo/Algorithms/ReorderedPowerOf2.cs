using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ReorderedPowerOf2
    {
        public bool ReorderedPowerOf2s(int n)
        {
            var num = 1;
            var digits = GetDigits(n);
            for (int i = 0; i < 31; i++)
            {
                if (digits.SequenceEqual(GetDigits(num)))
                    return true;

                num <<= 1;
            }

            return false;
        }

        private int[] GetDigits(int n)
        {
            var digits = new List<int>();
            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            digits.Sort();
            return digits.ToArray();
        }
    }
}
