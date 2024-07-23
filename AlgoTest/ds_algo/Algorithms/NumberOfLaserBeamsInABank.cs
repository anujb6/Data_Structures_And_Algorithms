using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class NumberOfLaserBeamsInABank
    {
        public static int NumberOfBeams(string[] bank)
        {
            Dictionary<int, int> rowBeamSums = new();
            int sum = 0;

            for (int i = 0; i < bank.Length; i++)
            {
                var laserCount = bank[i].Where(x => x=='1').Count();

                if (laserCount == 0)
                    continue;

                rowBeamSums[i] = laserCount;
            }
            var keys = rowBeamSums.Keys.ToList();
            for (int i=1; i<keys.Count; i++)
            {
                int lasers = rowBeamSums[keys[i - 1]] * rowBeamSums[keys[i]];
                sum += lasers;
            }

            return sum;
        }
    }
}
