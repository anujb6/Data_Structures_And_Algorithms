using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class ReorderList
    {
        public static void ReorderList1(ListNode head)
        {
            List<ListNode> list = new();

            while(head != null)
            {
                list.Add(head);
                head = head.next;   
            }

            int i = 0, j = list.Count - 1;

            while(i < j)
            {
                ListNode curr = list[i];
                ListNode back = list[j];

                curr.next = back;
                back.next = list[i + 1];

                j--;
                i++;
            }

            if(list.Count % 2 == 0)
                list[j + 1].next = null;
            else
                list[j].next = null;

            ListNode dummycurr = list[0];

            while(dummycurr != null)
            {
                Console.Write($"{dummycurr.val} ");
                dummycurr = dummycurr.next;
            }
        }
    }
}
