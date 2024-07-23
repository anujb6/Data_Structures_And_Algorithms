using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BitManipulation
{
    public class SingleNumber
    {
        public static int SingleNumberCalc(int[] nums)
        {
            var dic = new Dictionary<int, bool>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    dic.Remove(num);
                else
                    dic.Add(num, true);
            }

            return dic.Keys.FirstOrDefault();
        }
    }
}
