using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class TheLatestTimeToCatchABus
    {
        public static int LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity)
        {
            Array.Sort(buses);
            Array.Sort(passengers);

            int j = 0;
            int count = 0;
            for (int i=0; i<buses.Length; i++)
            {
                count = capacity;
                List<int> tempRec = new();
                while (count > 0 && j < passengers.Length && i < buses.Length && passengers[j] < buses[i])
                {
                    Console.Write($"{passengers[j]} ");
                    tempRec.Add(passengers[j]);
                    count-= 1;
                    j++;
                }
            }

            int b = (j < passengers.Length-1 && j >= 0) ? passengers[j - 1] : buses.LastOrDefault();

            if (count != 0)
                b = buses.LastOrDefault();

            HashSet<int> p = new(passengers);

            while(p.Contains(b)){
                b -= 1;
            }

            return b;       
        }
    }
}
