using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class NearestExit
    {
        private static IList<(int x, int y)> directions = new List<(int x, int y)>() { (-1, 0), (1, 0), (0, -1), (0, 1) };

        public int FindNearestExit(char[][] maze, int[] entrance)
        {
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((entrance[0], entrance[1]));
            maze[entrance[0]][entrance[1]] = '+';
            var count = 0;
            while (queue.Count > 0)
            {
                var n = queue.Count;
                while (n-- > 0)
                {
                    var position = queue.Dequeue();
                    foreach (var direction in directions)
                    {
                        var nextX = position.x + direction.x;
                        var nextY = position.y + direction.y;
                        if (IsOutOfBorderOrVisited(nextX, nextY, maze))
                            continue;
                        if (IsBorder(nextX, nextY, maze))
                            return ++count;
                        queue.Enqueue((nextX, nextY));
                        maze[nextX][nextY] = '+';
                    }
                }
                count++;
            }
            return -1;
        }

        private static bool IsBorder(int x, int y, char[][] maze) =>
            x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1;

        private static bool IsOutOfBorderOrVisited(int x, int y, char[][] maze) =>
            x < 0 || x >= maze.Length || y < 0 || y >= maze[0].Length || maze[x][y] != '.';
    }
}
