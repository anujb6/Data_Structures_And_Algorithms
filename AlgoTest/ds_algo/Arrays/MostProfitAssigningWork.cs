using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class MostProfitAssigningWork
    {
        public static int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            int sum = 0;

            foreach(int person in worker)
            {
                int profitSum = 0;

                for(int i=0; i<difficulty.Length; i++)
                {
                    if(person >= difficulty[i])
                    {
                        profitSum = Math.Max(profitSum, profit[i]);
                    }
                }

                sum += profitSum;
            }

            return sum;
        }
    }
}
