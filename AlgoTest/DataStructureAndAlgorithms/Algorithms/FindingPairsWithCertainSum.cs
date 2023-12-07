using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgoTest.DataStructureAndAlgorithms.Heap.MaximumSubSequenceScore;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class FindSumPairs
    {
        private Dictionary<int, int> freq;
        private int[] nums1;
        private int[] nums2;

        public FindSumPairs(int[] nums1, int[] nums2)
        {
            this.nums1 = nums1;
            this.nums2 = nums2;

            foreach (int n2 in nums2)
            {
                if (this.freq.Keys.Count > 0 && this.freq.ContainsKey(n2))
                    this.freq[n2] += 1;
                else
                    this.freq[n2] = 1;
            }
        }

        public void Add(int index, int val)
        {
            int old = this.nums2[index];
            int newval = old + val;
            this.nums2[index] = newval;
            this.freq[old] -= 1;
            if (this.freq.ContainsKey(newval))
                this.freq[newval] += 1;
            else
                this.freq[newval] = 1;
        }

        public int Count(int tot)
        {
            int result = 0;

            foreach (int n1 in this.nums1)
            {
                int keyToCheck = tot - n1;

                if (this.freq.ContainsKey(keyToCheck))
                    result += this.freq[keyToCheck];
            }

            return result;
        }
    }
}
