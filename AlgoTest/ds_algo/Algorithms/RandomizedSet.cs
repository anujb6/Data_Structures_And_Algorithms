using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class RandomizedSet
    {
        private readonly HashSet<int> _hashset;
        public RandomizedSet()
        {
            _hashset = new();
        }

        public bool Insert(int val)
        {
            if (!_hashset.Contains(val))
            {
                _hashset.Add(val);
                return true;
            }

            return false;
            
        }

        public bool Remove(int val)
        {
            if(!_hashset.Contains(val))
                return false;

            _hashset.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            Random rn = new();
            int rand = (int)Math.Floor((double)rn.Next(_hashset.Count));

            return _hashset.ElementAt(rand);
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
