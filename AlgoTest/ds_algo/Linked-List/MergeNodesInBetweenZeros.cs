using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class MergeNodesInBetweenZeros
    {
        public static ListNode MergeNodes(ListNode head)
        {
            ListNode curr = head.next;
            List<ListNode> linkedList = new();
            int sum = 0;

            while(curr != null)
            {
                if(curr.val != 0)
                   sum += curr.val;
                else
                {
                    ListNode node = new(sum);
                    if(linkedList.Count > 0)
                        linkedList[^1].next = node;
                    linkedList.Add(node);
                    sum = 0;
                }             

                curr = curr.next;
            }

            return linkedList[0];
        }
    }
}
