using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class NextGreaterNodeInLinkedList
    {
        public static int[] NextLargerNodes(ListNode head)
        {
            List<int> res = new();

            while(head != null)
            {
                var curr = head.next;

                if (curr == null)
                {
                    res.Add(0);
                    break;
                }
                else
                    while(curr.val <= head.val)
                    {
                        if (curr.next == null)
                            break;
                        curr = curr.next;
                    }

                res.Add(curr.val <= head.val ? 0: curr.val);
                head = head.next;

            }

            return res.ToArray();

        }

    }
}
