using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> store = new();

            foreach(int num in nums)
            {
                store.Add(num);
            }

            int i = 0;
            int maxCount = 0;

            while(i < nums.Length)
            {
                int count = 1;
                int currentNumber = nums[i]; 
                while(store.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    count++;
                }

                maxCount = Math.Max(maxCount, count);
                i++;
            }

            return maxCount;
            
        }
    }
}
