using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class ConvertAnArrayIntoA2DArrayWithConditions
    {
        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            Dictionary<int, int> map = new();
            int sum = 0;
            IList<IList<int>> res = new List<IList<int>>();
            
            foreach (int i in nums)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;

                sum += i;
            }

            while(sum > 0)
            {
                IList<int> row = new List<int>();
                foreach(int key in map.Keys)
                {
                    if (map[key] != 0)
                    {
                        row.Add(key);
                        sum -= key;
                        map[key] -= 1;
                    }
                }

                res.Add(row);
            }

            return res;
        }
    }
}
