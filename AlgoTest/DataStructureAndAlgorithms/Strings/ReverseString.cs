using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Strings
{
    public class ReverseString
    {
        public static void ReverseString1(char[] s)
        {
            int start = 0;
            int end = s.Length-1;

           Console.WriteLine($"Straight: {String.Join("",s)}");
           
           while (start < end)
           {
                (s[end], s[start]) = (s[start], s[end]);
                start++;
                end--;
           }

           Console.WriteLine($"Reversed: {String.Join("",s)}");

        }
    }
}
