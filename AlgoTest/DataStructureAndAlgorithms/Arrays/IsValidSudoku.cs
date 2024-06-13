using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Arrays
{
    public class IsValidSudoku
    {
        public static bool IsValidSudoku1(char[][] board)
        {
            Dictionary<int, List<char>> rows = new();
            Dictionary<int, List<char>> cols = new();
            Dictionary<int, List<char>> squares= new();

            for (int i=0; i<board.Length; i++)
            {
                for(int j=0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    if (rows.ContainsKey(i))
                    {
                        if (rows[i].Contains(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            rows[i].Add(board[i][j]);
                        }
                    }
                    else
                    {
                        rows[i] = new List<char>() { board[i][j] };
                    }

                    if(cols.ContainsKey(j))
                    {
                        if (cols[j].Contains(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            cols[j].Add(board[i][j]);
                        }
                    }
                    else
                    {
                        cols[j] = new List<char>() { board[i][j] };
                    }

                    int square = (int)(i / 3) * 3 + (j / 3);

                    if (squares.ContainsKey(square))
                    {
                        if (squares[square].Contains(board[i][j]))
                            return false;
                        else
                            squares[square].Add(board[i][j]);  
                    }
                    else
                        squares[square] = new List<char> { board[i][j] };
                }
            }


            return true;

        }
    }
}
