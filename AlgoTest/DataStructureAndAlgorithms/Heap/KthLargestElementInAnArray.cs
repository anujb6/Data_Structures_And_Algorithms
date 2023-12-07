using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Heap
{
    public class KthLargestElementInAnArray
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            var minHeap = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                minHeap.Enqueue(num, num);

                if (minHeap.Count > k)
                    minHeap.Dequeue();
            }

            var ele =  minHeap.Peek();
            return ele;
        }
    }
}
