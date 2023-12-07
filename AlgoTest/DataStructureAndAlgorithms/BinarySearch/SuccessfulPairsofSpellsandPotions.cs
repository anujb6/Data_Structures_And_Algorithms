using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.BinarySearch
{
    public class SuccessfulPairsofSpellsandPotions
    {
        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            /*            var result = new List<int>();
                        Array.Sort(potions);

                        foreach (var spell in spells)
                        {
                            var count = 0;
                            for (var i = 0; i < potions.Length; i++)
                            {
                                if (spell * (long)potions[i] >= success)
                                {
                                    count = potions.Length - i;
                                    break;
                                }
                            }
                            result.Add(count);
                        }

                        return result.ToArray();*/

            Array.Sort(potions);
            int[] res = new int[spells.Length];
            for (int i = 0; i < spells.Length; i++)
            {
                int left = 0;
                int right = potions.Length - 1;
                int tem = -1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if ((long)potions[mid] * spells[i] >= success)
                    {
                        right = mid - 1;
                        tem = mid;
                    }
                    else
                        left = mid + 1;
                }
                if (tem != -1)
                   res[i] = potions.Length - tem;
                else 
                    res[i] = 0;

            }
            return res;
        }
    }
}
