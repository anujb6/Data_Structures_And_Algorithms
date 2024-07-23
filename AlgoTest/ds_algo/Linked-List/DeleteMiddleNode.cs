using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.Data_Structure_Sums.Linked_List
{
    public class DeleteMiddleNode
    {
        public static ListNode RemoveMiddle(ListNode head)
        {
            int length = 0;

            var curr = head;
            while (curr != null)
            {
                length++;
                curr = curr.next;
            }

            double mid = Math.Ceiling((double)length / 2);

            curr = head;

            while (mid > 0)
            {
                curr = curr.next;
                mid -= 1;
            }

            curr.next = curr.next.next;

            return head;
        }
    }
}
