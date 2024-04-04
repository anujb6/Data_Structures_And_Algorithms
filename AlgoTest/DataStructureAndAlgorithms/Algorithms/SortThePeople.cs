using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class SortThePeople
    {
        public static string[] SortPeople(string[] names, int[] heights)
        {
            SortedDictionary<int, string> dic = new();

            foreach (var (name, height) in names.Zip(heights))
            {
                dic.Add(height, name);
            }

            var res = dic.Values.ToArray();
            Array.Reverse(res);

            return res;
        }
    }
}
