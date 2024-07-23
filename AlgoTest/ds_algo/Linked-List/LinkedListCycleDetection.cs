using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class LinkedListCycleDetection
    {
        public static bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new();

            while(head != null)
            {
                if (visited.Contains(head))
                {
                    return true;
                }

                visited.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
