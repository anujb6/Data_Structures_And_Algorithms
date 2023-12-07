using AlgoTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class OddEvenLinkedList
    {
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode current = head;
            var oddNode = new ArrayList();
            int index = 0;
            while (current != null)
            {
                if (!((index + 1) % 2 == 0) && current.next != null)
                {
                    oddNode.Add(current.next.val);
                    current.next = current.next.next;
                    index -= 1;
                }
                index++;
                current = current.next;
            }

            var newCurr1 = head;
            while (newCurr1.next != null)
            {
                newCurr1 = newCurr1.next;
            }

            foreach (int nodeData in oddNode)
            {
                newCurr1.next = new ListNode(nodeData);
                newCurr1 = newCurr1.next;
            }

            return head;
        }
    }
}
