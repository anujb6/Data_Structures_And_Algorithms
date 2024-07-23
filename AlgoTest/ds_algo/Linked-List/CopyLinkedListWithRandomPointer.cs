using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class CopyLinkedListWithRandomPointer
    {
        public static ListNode CopyRandomList(ListNode head)
        {
            Dictionary<ListNode, ListNode> oldToCopy = new();

            ListNode cur = head;
            while (cur != null)
            {
                ListNode copy = new(cur.val);
                oldToCopy[cur] = copy;
                cur = cur.next;
            }

            cur = head;
            while (cur != null)
            {
                ListNode copy = oldToCopy[cur];
                copy.next = cur.next != null ? oldToCopy[cur.next] : null;
                copy.random = cur.random != null ? oldToCopy[cur.random] : null;
                cur = cur.next;
            }

            return head != null ? oldToCopy[head] : null;
        }
    }
}
