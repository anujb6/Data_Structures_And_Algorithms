using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class DestinationCity
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, string> map = new();

            for(int i=0; i<paths.Count; i++)
            {
                var a = paths[i][0];
                var b = paths[i][1];
                
                map.Add(a, b);
            }

            return Dfs(paths[0][0], map);
        }

        static string Dfs(string source, Dictionary<string, string> map)
        {
            Stack<string> stack = new(new List<string>() { source });
            var currCity = "";
            while (stack.Count > 0)
            {
                currCity = stack.Pop();

                if (!map.ContainsKey(currCity))
                    break;

                stack.Push(map[currCity]);
            }

            return currCity;
        }
    }
}
