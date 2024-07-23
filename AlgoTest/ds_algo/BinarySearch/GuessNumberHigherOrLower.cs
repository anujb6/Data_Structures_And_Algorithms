using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class GuessNumberHigherOrLower
    {
        static int guess(int num, int n) 
        {
            if(num == n)
                return 0;
            else if(num < n)
                return 1;
            else 
                return -1;
        }
        public static int GuessNumber(int n)
        {
            int low = 1;
            int high = n;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int result = guess(mid, n);

                if (result == 0)
                    return mid;
                else if (result == -1)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }
}
