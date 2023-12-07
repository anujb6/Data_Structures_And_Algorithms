using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Linked_List
{
    public class MaxTwinSumOfLinkedList
    {
        public int PairSum(ListNode head)
        {
            if (head == null)
                return 0;

            List<int> arr = new();
            ListNode curr = head;

            while (curr != null)
            {
                arr.Add(curr.val);
                curr = curr.next;
            }

            int left = 0;
            int right = arr.Count - 1;
            int max = 0;

            while (left < right)
            {
                max = Math.Max(max, arr[left] + arr[right]);
                left++;
                right--;
            }

            return max;
        }
    }
}
