using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects2d
{
    class Rectangle : Object2D
    {
        public double a { get; set; }
        public double b { get; set; }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double ComputeArea()
        {
            return a * b;
        }

        public override void Draw()
        {
            Console.WriteLine("rectangle with sites a: {0} b: {1} with area: {2}", a, b, ComputeArea());
        }
    }
}
