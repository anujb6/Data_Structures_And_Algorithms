using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class RemoveNodeFromEndOfTheLinkedList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int track = 1;
            ListNode backer = head;
            ListNode curr = head;

            while (curr.next != null)
            {
                if(track >= n+1)
                    backer = backer.next;

                track++;
                curr = curr.next;
            }


            ListNode next = backer.next.next == null ? null: backer.next.next;
            backer.next = next;

            return head;
        }
    }
}
