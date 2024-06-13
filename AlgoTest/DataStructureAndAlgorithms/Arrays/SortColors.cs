using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class SortColors
    {
        public static void SortColors1(int[] nums)
        {
            Dictionary<int, int> map = new();

            foreach (var i in nums)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;
            }

            Array.Clear(nums);
            List<int> newNums = nums.ToList();

            foreach(int i in nums)
            {
                for(int j=0; j < map[i]; j++)
                {
                    newNums.Add(i);
                }
            }

            nums.Concat(newNums.ToArray());

        }
    }
}
