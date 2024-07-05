using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class TimeMap
    {
        private Dictionary<(string, int), string> _map;
        private (string, int) _min = ("", int.MaxValue);
        public TimeMap() 
        {
            _map = new();
        }

        public void Set(string key, string value, int timestamp) {
            _map.Add((key, timestamp), value);
            
            if(timestamp < _min.Item2)
                _min = (key, timestamp);

        }

        public string Get(string key, int timestamp) {
            if(_map.ContainsKey((key, timestamp)))
            {
                string result = _map[(key, timestamp)];
                return result;
            }
            else
            {
                if (timestamp < _min.Item2)
                    return "";
                else
                {
                    int min = int.MaxValue;
                    (string, int) keyStore = new();
                    foreach(var (it1, it2) in _map.Keys)
                    {
                        if (it2 < timestamp && it2 < min)
                            keyStore = (it1, it2);
                        else if (it2 > timestamp)
                            break;
                    }

                    return _map[keyStore];
                }
            }
        }

    }
}
