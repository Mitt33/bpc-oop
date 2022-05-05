using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects2d
{
    class Ellipse : Object2D
    {
        public double a { get; set; }
        public double b { get; set; }

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double ComputeArea()
        {
            return a * b * Math.PI;
        }

        public override void Draw()
        {
            Console.WriteLine("ellipse with major radius a: {0} and minor b: {1} with area: {2}", a, b, ComputeArea());
        }
    }
}
