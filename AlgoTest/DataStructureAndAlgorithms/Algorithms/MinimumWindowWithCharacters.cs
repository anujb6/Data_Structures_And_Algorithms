using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MinimumWindowWithCharacters
    {
        public static string MinWindow(string s , string t)
        {
            List<char> characters = new(t);
            List<char> words = new(characters);
            int minLen = int.MaxValue;
            string substr = string.Empty;

            if (characters.Count > s.Length)
                return "";

            for(int i=0; i<s.Length; i++)
            {
                int j = i + 1;
                if (characters.Contains(s[i]))
                {
                    characters.Remove(s[i]);
                    while(j < s.Length && characters.Count > 0)
                    {
                        if (characters.Contains(s[j]))
                            characters.Remove(s[j]);
                        j++;
                    }

                    string subst = s.Substring(i, j - i);
                    if (minLen > subst.Length && subst.Length >= t.Length && characters.Count == 0)
                    {
                        minLen = subst.Length;
                        substr = subst;
                    }
                    characters = new List<char>(words);
                }

            }

            return substr;

        }
    }
}
