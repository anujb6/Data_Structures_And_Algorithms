using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class CarFleet
    {
        public static int CarFleet1(int target, int[] position, int[] speed)
        {
            var pair = position.Zip(speed, (p, s) => new { Position = p, Speed = s }).ToList();

            pair.Sort((a, b) => b.Position.CompareTo(a.Position));

            List<double> stack = new();

            foreach (var car in pair)
            {

                double time = (double)(target - car.Position) / car.Speed;

                if (stack.Count == 0 || time > stack[stack.Count - 1])
                {
                    stack.Add(time);
                }
            }

            return stack.Count;
        }
    }
}
