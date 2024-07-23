using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level1
{
    public class BreadthFirstSearch
    {
        public static void BFS(Dictionary<int, List<int>> adjList, int intSource)
        {
            Queue<int> queue = new(new[] { intSource });

            while(queue.Count > 0)
            {
                var curr = queue.Dequeue();
                Console.WriteLine(curr + " ");

                foreach( var neighbour in adjList[curr] ) 
                {
                    queue.Enqueue(neighbour);
                }
            }
        }
    }
}
