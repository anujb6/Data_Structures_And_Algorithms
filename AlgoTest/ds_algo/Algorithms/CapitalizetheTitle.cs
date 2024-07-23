using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CapitalizetheTitle
    {
        public static string CapitalizeTitle(string title)
        {
            string[] words = title.Split(' ');

            for(int i=0; i<words.Length; i++)
            {
                if (words[i].Length > 2) 
                {
                    words[i] = words[i].ToLower();
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                else
                    words[i] = words[i].ToLower();
            }

            return string.Join(" ", words);
        }
    }
}
