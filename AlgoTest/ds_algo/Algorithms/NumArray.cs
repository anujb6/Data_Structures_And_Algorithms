using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class NumArray
    {
        private int[] _nums;
        public NumArray(int[] nums)
        {
            _nums = nums;
        }

        public int SumRange(int left, int right)
        {
            right--;
            return _nums[left..right].Sum();
        }
    }
}
