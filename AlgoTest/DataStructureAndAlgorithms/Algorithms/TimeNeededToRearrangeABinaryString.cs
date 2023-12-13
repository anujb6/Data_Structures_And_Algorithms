using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class TimeNeededToRearrangeABinaryString
    {
        public static int SecondsToRemoveOccurrences(string s)
        {
            int count = 0;
            var arr = s.ToCharArray();

            while (true)
            {
                int occurenceCount = 0;
                List<List<int>> pos = new();

                for(var i=1; i<arr.Length; i++)
                {
                    if (arr[i-1] == '0' && arr[i] == '1')
                    {
                        pos.Add(new List<int>() { i-1, i });
                        occurenceCount++;
                    }
                }

                if (occurenceCount == 0)
                    break;

                foreach(var positions in pos)
                {
                    arr[positions[0]] = '1';
                    arr[positions[1]] = '0';
                }

                count++;

            }

            return count;
        }
    }
}
