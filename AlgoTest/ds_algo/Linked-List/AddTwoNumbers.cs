using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class AddTwoNumbers
    {
        public static ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            List<int> results = new();
            string first = "";
            string second = "";
            while (l1 != null || l2 != null)
            {
                if(l1 != null)
                {
                    first = l1.val.ToString() + first;
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    second = l2.val.ToString() + second;
                    l2 = l2.next;
                }
            }

            int num = Int32.Parse(first) + Int32.Parse(second);
            string val = num.ToString();

            ListNode dummy = new(0);
            ListNode current = dummy;

            for (int i = val.Length - 1; i >= 0; i--)
            {
                current.next = new ListNode(val[i] - '0');
                current = current.next;
            }

            return dummy.next;
        }
    }
}
