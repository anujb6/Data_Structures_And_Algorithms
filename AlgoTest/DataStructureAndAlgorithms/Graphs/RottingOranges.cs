using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Graphs
{
    public class RottingOranges
    {
        public static int OrangesRotting(int[][] grid)
        {
            Queue<List<int>> rottenOranges = new();
            var freshCount = 0;
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                        freshCount++;
                    else if (grid[i][j] == 2)
                        rottenOranges.Enqueue(new List<int>() { i, j });
                }
            }

            var directions = new List<IList<int>> {
                        new List<int> { 1, 0 },
                        new List<int> { -1, 0 },
                        new List<int> { 0, 1 },
                        new List<int> { 0, -1 }
                    };

            while (rottenOranges.Count > 0 && freshCount > 0)
            {
                for (var i = 0; i < rottenOranges.Count; i++)
                {
                    var rotten = rottenOranges.Dequeue();
                    var row = rotten[0];
                    var col = rotten[1];

                    foreach (var dir in directions)
                    {
                        var rowIndex = row + dir[0];
                        var colIndex = col + dir[1];

                        if (rowIndex < 0 ||
                            rowIndex > grid[0].Length-1 ||
                            colIndex < 0 ||
                            colIndex > grid.Length - 1 
                            || grid[rowIndex][colIndex] != 1)
                            continue;

                        grid[rowIndex][colIndex] = 2;
                        rottenOranges.Enqueue(new List<int> { rowIndex, colIndex });
                        freshCount--;
                    }
                }

                result++;
            }

            return freshCount == 0 ? result : -1;
        }
    }
}
