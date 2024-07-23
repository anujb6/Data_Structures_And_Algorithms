using AlgoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class ConvertBinaryNumberInALinkedListToInteger
    {
        public static int GetDecimalValue(ListNode head)
        {
            string binary = "";

            while(head != null)
            {
                binary += head.val.ToString();
                head = head.next;
            }

            return Convert.ToInt32(binary, 2);
        }
    }
}
