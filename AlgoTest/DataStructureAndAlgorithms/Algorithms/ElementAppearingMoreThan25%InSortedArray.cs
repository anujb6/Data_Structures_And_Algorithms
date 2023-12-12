using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ElementAppearingMoreThan25_InSortedArray
    {
        public static int FindSpecialInteger(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];

            var occurence = (int)Math.Ceiling((double) arr.Length / 4);
            Dictionary<int, int> dic = new();

            foreach (var item in arr)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic[item] = 1;
            }

            return dic.Keys.Where(x => dic[x] >= occurence).Max();
        }
    }
}
