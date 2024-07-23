using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class MagneticForceBetweenTwoBalls
    {
        public static int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);

            var left = 1;
            var right = position[^1] - position[0];

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (CheckDistance(mid))
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return right;

            bool CheckDistance(int distance)
            {
                var balls = 0;
                var prev = int.MinValue;

                foreach (var curr in position)
                {
                    if (prev + distance <= curr)
                    {
                        balls += 1;
                        prev = curr;

                        if (balls == m)
                            return true;
                    }
                }

                return false;
            }
        }
    }
}
