using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs.Level2
{
    public class CheckIfItIsPossibleToFinishAllTask
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<List<int>> graph = BuildGraph(numCourses, prerequisites);

            bool[] visited = new bool[numCourses];
            bool[] recursionStack = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                if (!visited[i] && IsCyclic(graph, i, visited, recursionStack))
                {
                    return false;
                }
            }

            return true;
        }

        private static List<List<int>> BuildGraph(int numCourses, int[][] prerequisites)
        {
            List<List<int>> graph = new List<List<int>>(numCourses);

            for (int i = 0; i < numCourses; i++)
            {
                graph.Add(new List<int>());
            }

            foreach (var prerequisite in prerequisites)
            {
                graph[prerequisite[0]].Add(prerequisite[1]);
            }

            return graph;
        }

        private static bool IsCyclic(List<List<int>> graph, int node, bool[] visited, bool[] recursionStack)
        {
            if (recursionStack[node])
            {
                return true; // Cycle detected
            }

            if (visited[node])
            {
                return false; // Already visited and not part of a cycle
            }

            visited[node] = true;
            recursionStack[node] = true;

            foreach (var neighbor in graph[node])
            {
                if (IsCyclic(graph, neighbor, visited, recursionStack))
                {
                    return true;
                }
            }

            recursionStack[node] = false;

            return false;
        }
    }
}
