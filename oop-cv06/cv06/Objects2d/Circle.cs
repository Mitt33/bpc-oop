using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects2d
{
    class Circle : Object2D
    {
        public double r { get; set;  }

        public Circle(double r)
        {
            this.r = r;
        }

        public override double ComputeArea()
        {
            return Math.PI * r * r; 
        }

        public override void Draw()
        {
            Console.WriteLine("circle with radius: {0} and area: {1}", r, ComputeArea());
        }
    }
}
