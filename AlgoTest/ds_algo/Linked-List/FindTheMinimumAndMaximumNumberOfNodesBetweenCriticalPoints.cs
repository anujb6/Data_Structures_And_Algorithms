using AlgoTest.Data_Structure_Sums.Linked_List;
using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints
    {
        public static int[] NodesBetweenCriticalPoints(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            {
                return new int[] { -1, -1 };
            }

            List<int> criticalPoints = new();
            int index = 1; 
            ListNode prev = head;
            ListNode curr = head.next;

            while (curr.next != null)
            {
                if ((curr.val > prev.val && curr.val > curr.next.val) || (curr.val < prev.val && curr.val < curr.next.val))
                {
                    criticalPoints.Add(index);
                }

                prev = curr;
                curr = curr.next;
                index++;
            }

            if (criticalPoints.Count < 2)
            {
                return new int[] { -1, -1 };
            }

            int minDistance = int.MaxValue;
            int maxDistance = criticalPoints[^1] - criticalPoints[0];

            for (int i = 0; i < criticalPoints.Count - 1; i++)
            {
                minDistance = Math.Min(minDistance, criticalPoints[i + 1] - criticalPoints[i]);
            }

            return new int[] { minDistance, maxDistance };
        }
    }

}
