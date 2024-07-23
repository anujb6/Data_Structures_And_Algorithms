using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class FaultyKeyBoard
    {
        public static string FinalString(string s)
        {
            string response = "";
            foreach(char i in s)
            {
                if (i != 'i')
                    response += i;
                else
                    response = Reverse(response);
            }

            return response;
        }

        private static string Reverse(string s)
        {
            string response = "";

            for(int i=(s.Length-1); i>=0; i--)
            {
                response += s[i];
            }

            return response;
        }
    }
}
