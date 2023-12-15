using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Algorithms
{
    public class GenerateRandomPointInACircle
    {
        private double _radius;
        private double _xCenter;
        private double _yCenter;

        public GenerateRandomPointInACircle(double radius, double x_center, double y_center) 
        { 
            _radius = radius;
            _xCenter = x_center;
            _yCenter = y_center;
        }

        public double[] Randpoint()
        {
            Random rand = new Random();
            var angle = rand.NextDouble() * 2 * Math.PI;
            var hypotenuse = Math.Sqrt(rand.NextDouble()) * _radius;
            var adj = Math.Cos(angle) * hypotenuse;
            var opp = Math.Sin(angle) * hypotenuse;

            return new double[] { _xCenter + adj, _yCenter+ opp };
        }
    }

}
