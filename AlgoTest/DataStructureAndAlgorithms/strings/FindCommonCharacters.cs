using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.strings
{
    public class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] words)
        {
            Dictionary<char, int> map = new();
            List<string> result = new();
            int count = 0;


            foreach (string word in words)
            {
                foreach(char character in word)
                {
                    if (map.ContainsKey(character))
                        map[character] += 1;
                    else
                        map[character] = 1;
                }
            }

            foreach(var character in map.Keys)
            {
                foreach(var word in words)
                {
                    if (word.Contains(character))
                        count++;
                }

                if(count != words.Length)
                {
                    map.Remove(character);
                }
               
                count = 0;
               
            }

            if (map.Count <= 0)
                return result;

            foreach(var character in map.Keys)
            {
                int insertLoop = map[character] / words.Length;

                for(int i=0; i < insertLoop; i++)
                {
                    result.Add(character.ToString());
                }
            }


            return result;

        }
    }
}
