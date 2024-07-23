using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class PathCrossing
    {
        public static bool IsPathCrossing(string path)
        {
            int xCoordinate = 0, yCoordinate = 0;
            HashSet<string> visited = new();
            visited.Add("0, 0");
            foreach(var c in path)
            {
                if (c == 'N')
                    yCoordinate++;
                else if (c == 'S')
                    yCoordinate--;
                else if (c == 'E')
                    xCoordinate++;
                else
                    xCoordinate--;

                if (visited.Contains($"{xCoordinate}, {yCoordinate}"))
                    return true;

                visited.Add($"{xCoordinate}, {yCoordinate}");
            }

            return false;
        }
    }
}
