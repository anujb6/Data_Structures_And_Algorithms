using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Heap
{
  /*          var totalCost = 0;
            for(var i=0; i<k; i++)
            {
                var copy = costs[0..(candidates)].Concat(costs[((costs.Length) - candidates)..(costs.Length)]);
                var min = copy.Min();
                totalCost += min;
                var cost1 = costs.ToList();
                cost1.RemoveAt(cost1.IndexOf(min));
                costs = cost1.ToArray();
            }

            return totalCost;*/
    public class TotalCostToHireKWorkers
    {
        public static long TotalCost(int[] costs, int k, int candidates)
        {
            long totalCost = 0;
            var leftQueue = new PriorityQueue<int, int>();
            var rightQueue = new PriorityQueue<int, int>();

            var leftIndex = 0;
            var rightIndex = costs.Length - 1;

            while (k > 0)
            {
                while (leftQueue.Count < candidates && leftIndex <= rightIndex)
                {
                    leftQueue.Enqueue(costs[leftIndex], costs[leftIndex]);
                    leftIndex++;
                }

                while (rightQueue.Count < candidates && leftIndex <= rightIndex)
                {
                    rightQueue.Enqueue(costs[rightIndex], costs[rightIndex]);
                    rightIndex--;
                }

                var leftMinCost = leftQueue.Count > 0 ? leftQueue.Peek() : int.MaxValue;
                var rightMinCost = rightQueue.Count > 0 ? rightQueue.Peek() : int.MaxValue;

                totalCost += leftMinCost <= rightMinCost ? leftQueue.Dequeue() : rightQueue.Dequeue();

                k--;
            }

            return totalCost;
        }
    }
}
