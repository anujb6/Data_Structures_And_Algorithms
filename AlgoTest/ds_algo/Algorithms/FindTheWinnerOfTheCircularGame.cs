using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class FindTheWinnerOfTheCircularGame
    {
        public static int FindTheWinner(int n, int k)
        {
            List<int> players = Enumerable.Range(1, n).ToList();
            int i = 0;

            while(players.Count > 1) 
            {
                i += k - 1;

                if(i > players.Count - 1)
                {
                    i %= players.Count; 
                }

                players.RemoveAt(i);
            }

            return players[0];
        }
    }
}
