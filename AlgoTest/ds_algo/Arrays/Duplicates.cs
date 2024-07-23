using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class Duplicates
    {
        public static bool ContainsDuplicates(int[] nums)
        {
            HashSet<int> store = new();

            foreach(int num in nums)
            {
                if(store.Contains(num)) return true;
                else
                    store.Add(num);
            }

            return false;
        }
    }
}
