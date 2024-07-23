using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class DailyTemperature
    {
        public static int[] DailyTemperatures(int[] temparatures)
        {
            List<int> result = new();

            for(int i=0; i<temparatures.Length; i++)
            {
                int j = i + 1;
                int count = 0;
                while (j < temparatures.Length)
                {
                    count++;
                    if (temparatures[j] > temparatures[i])
                    {
                        break;
                    }
                    else
                    {
                        j++;
                    }

                    if (j == temparatures.Length)
                        count = 0;
                }

                result.Add(count);
            }

            return result.ToArray();
        }
    }
}
