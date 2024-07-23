using AlgoTest.DataStructureAndAlgorithms.Binary_trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.Models
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode? random;

        public ListNode(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
