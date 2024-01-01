using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class MyCircularDeque
    {
        private readonly List<int> _queue;
        private readonly int _len;

        public MyCircularDeque(int k)
        {
            _queue = new(k);
            _len = k;
        }

        public bool InsertFront(int value)
        {
            if(_queue.Count < _len)
            {
                _queue.Insert(0, value);
                return true;
            }

            return false;
        }

        public bool InsertLast(int value)
        {
            if (_queue.Count < _len)
            {
                _queue.Add(value);
                 return true;
            }

            return false;
        }

        public bool DeleteFront()
        {
            if (_queue.Count > 0)
            {
                _queue.RemoveAt(0);
                return true;
            }

            return false;
        }

        public bool DeleteLast()
        {
            if (_queue.Count > 0)
            {
                _queue.RemoveAt(_queue.Count - 1);
                return true;
            }

            return false;
        }

        public int GetFront()
        {
            return _queue.Count > 0 ? _queue[0] : -1;
        }

        public int GetRear()
        {
            return _queue.Count > 0 ? _queue[^1] : -1;
        }

        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }

        public bool IsFull()
        {
            return _queue.Count >= _len;
        }
    }
}
