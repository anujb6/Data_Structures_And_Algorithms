using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.MonotonicStack
{
    public class DailyTemperatures
    {
        public static int[] DailyTemperaturesCalculation(int[] temperatures)
        {
            /*            List<int> tempDays = new();
                        for(int i=0; i<temperatures.Length; i++)
                        {
                            int count = 0;
                            for(int j=i+1; j<temperatures.Length; j++)
                            {
                                count++;

                                if (j == temperatures.Length - 1 && temperatures[j] <= temperatures[i])
                                    count = 0;

                                if (temperatures[j] > temperatures[i])
                                    break;

                            }
                            tempDays.Add(count);
                        }

                        return tempDays.ToArray();*/

            int[] res = new int[temperatures.Length];
            Stack<(int temp, int day)> stack = new();

            for(int i=temperatures.Length-1; i>=0; i--)
            {
                while(stack.Count > 0 && stack.Peek().temp <= temperatures[i]) 
                {
                    stack.Pop();
                }

                res[i] = stack.Count == 0 ? 0 : stack.Peek().day - 1;
                stack.Push((temperatures[i], i));
            }

            return res;
        }
    }
}
