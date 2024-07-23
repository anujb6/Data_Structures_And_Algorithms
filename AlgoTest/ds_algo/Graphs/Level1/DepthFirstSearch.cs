using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class DepthFirstSearch
    {
        public static void DFS(Dictionary<int, List<int>> adjList, int source)
        {
           Stack<int> stack = new(new[] {source});

            while(stack.Count > 0)
            {
                var curr = stack.Pop();

                Console.Write(curr + " ");
                foreach(var neighbour in adjList[curr])
                {
                    stack.Push(neighbour);
                }
            }
        }
    }
}
