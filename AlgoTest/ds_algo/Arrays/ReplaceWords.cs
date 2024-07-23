using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class ReplaceWords
    {
        public static string ReplaceWords1(IList<string> dictionary, string sentence)
        {
            string[] words = sentence.Split(' ');
            

            for(int i =0; i<words.Length; i++)
            {
                for(int j=0; j< dictionary.Count; j++)
                {
                    if (words[i].StartsWith(dictionary[j]))
                    {
                        words[i] = dictionary[j];
                    }
                }
            }

            return String.Join(" ", words);
            
        }
    }
}
