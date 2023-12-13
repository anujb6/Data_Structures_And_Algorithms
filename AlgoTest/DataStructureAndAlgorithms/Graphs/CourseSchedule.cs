using AlgoTest.DataStructureAndAlgorithms.Graphs.Level1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class CourseSchedule
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> adjList = new();
            foreach (var edges in prerequisites)
            {
                var a = edges[0];
                var b = edges[1];

                if (adjList.ContainsKey(a))
                    adjList[a].Add(b);
                else
                    adjList.Add(a, new List<int>() { b });
            }

            foreach(var node in adjList.Keys)
            {
                HashSet<int> track = new();
                if (DepthRouting(node, track, adjList))
                    return false;
            }

            return true;
        }

        private static bool DepthRouting(int node, HashSet<int> track, Dictionary<int, List<int>> adjList)
        {
            track.Add(node);

            if (adjList.ContainsKey(node))
            {
                foreach(var neighbour in adjList[node])
                {
                    if (track.Contains(neighbour) || DepthRouting(neighbour, track, adjList))
                        return true;
                }
            }

            track.Remove(node);
            return false;
        }


    }
}
