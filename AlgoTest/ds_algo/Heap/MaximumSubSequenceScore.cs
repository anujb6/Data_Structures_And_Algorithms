using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Heap
{
    public class MaximumSubSequenceScore
    {
        public static long MaxScore(int[] nums1, int[] nums2, int k)
        {
            int n = nums1.Length;
            Num[] nums = new Num[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = new Num(nums1[i], nums2[i]);
            }

            Array.Sort(nums, (a, b) => {
                return b.num2 - a.num2;
            });

            PriorityQueue<int, int> pq = new();
            long res = 0, sum = 0;

            for (int i = 0; i < n; i++)
            {
                pq.Enqueue(nums[i].num1, nums[i].num1);
                sum += nums[i].num1;

                if (pq.Count > k) 
                    sum -= pq.Dequeue();
                if (pq.Count == k) 
                    res = Math.Max(res, sum * nums[i].num2);
            }

            return res;
        }

        public class Num
        {
            public int num1;
            public int num2;

            public Num(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }
        }
    }
}
