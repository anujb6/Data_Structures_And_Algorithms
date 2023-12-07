using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class Dota2Senate
    {
        public static void ComputeDota2Senate(string senate)
        {
            int j = 0;

            while (j < senate.Length)
            {
                if (senate[0].Equals('D'))
                {
                    j = 0;
                    while (!senate[j].Equals('R'))
                    {
                        j++;
                    }
                    senate = senate.Remove(j, 1);
                }
                else
                {
                    j = 0;
                    while (!senate[j].Equals('D'))
                    {
                        j++;
                    }

                    senate = senate.Remove(j, 1);
                }

                senate += senate[0];
                senate = senate.Remove(0, 1);
            }

            Console.WriteLine(senate);
        }
    }
}
