using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class CrawlerLogFolder
    {

        public static int MinOperations(string[] logs)
        {
            Stack<string> stack = new();

            stack.Push("main");
            string currDir = "";
            for(int i=0; i<logs.Length; i++)
            {
                if (logs[i] != "./" && logs[i] != "../")
                {
                    currDir = logs[i];
                    stack.Push(logs[i]);
                }
                else if (logs[i] == "../" && stack.Count > 1)
                {
                    stack.Pop();
                    currDir = stack.Peek();
                }
            }

            return stack.Count-1;
        }
    }
}
