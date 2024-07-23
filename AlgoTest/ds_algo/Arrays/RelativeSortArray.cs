using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class RelativeSortArray
    {
        public static int[] RelativeSortArray1(int[] arr1, int[] arr2)
        {
            List<int> result = new();
            Dictionary<int, int> map = new();
            List<int> notPresent = new();
            List<int> arr1List = arr1.ToList();
 
            foreach(int i in arr1)
            {
                if(map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;
            }

            foreach(int i in arr2)
            {
                for(int j=0; j<map[i]; j++)
                {
                    result.Add(i);
                    arr1List.Remove(i);
                }
            }
            arr1List.Sort();
            return result.Concat(arr1List).ToArray();
        }
    }
}
