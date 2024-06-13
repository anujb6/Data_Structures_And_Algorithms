using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class MinimumNumberOfMovesToSeatEveryone
    {
        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            int count = 0;

            foreach(var (seat, student) in seats.Zip(students)) 
            {
                count += Math.Abs((seat - student));
            }

            return count;
        }
    }
}
