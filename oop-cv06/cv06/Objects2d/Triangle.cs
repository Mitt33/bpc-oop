using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects2d
{
    class Triangle : Object2D
    {
        public double a { get; set; }
        public double v { get; set; }

        public Triangle(double a, double v)
        {
            this.a = a;
            this.v= v;
        }

        public override double ComputeArea()
        {
            return (a * v) / 2;
        }

        public override void Draw()
        {
            Console.WriteLine("triangle with site a: {0} and its perpendicular height v: {1} with area: {2}", a, v, ComputeArea());
        }
    }
}
