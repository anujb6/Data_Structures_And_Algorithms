using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class AverageWaitingTime
    {
        public static double AverageWaitingTime1(int[][] customers)
        {
            double currentTime = customers[0][0] + customers[0][1];
            List<double> results = new() { currentTime - customers[0][0] };

            for (int i=1; i<customers.Length; i++)
            {
                if(customers[i][0] > currentTime)
                    currentTime = customers[i][0] + customers[i][1];
                else
                    currentTime += customers[i][1];

                results.Add(currentTime - customers[i][0]);
            }

            return (double)results.Average();
        }
    }
}
