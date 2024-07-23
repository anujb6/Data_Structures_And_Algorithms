using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class FindPlayersWithZeroOrOneLosses
    {

        //https://leetcode.com/problems/find-players-with-zero-or-one-losses/description/?envType=daily-question&envId=2024-01-15
        public static IList<IList<int>> FindWinners(int[][] matches)
        {
            Dictionary<int, int> losers = new();

            SortedSet<int> lostOneMatch = new();
            SortedSet<int> unBeatable = new();

            foreach (var match in matches)
            {
                if (losers.ContainsKey(match[1]))
                    losers[match[1]]++;
                else
                    losers[match[1]] = 1;
            }


            foreach (var match in matches)
            {
                if (!losers.ContainsKey(match[0]))
                    unBeatable.Add(match[0]);

                if (losers[match[1]] == 1)
                    lostOneMatch.Add(match[1]);
            }

            return new List<IList<int>>() { unBeatable.ToList(), lostOneMatch.ToList() };
        }
    }
}
