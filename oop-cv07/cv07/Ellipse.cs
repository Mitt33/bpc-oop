using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Ellipse : Object2D
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
                Area = ComputeArea();

            }
        }
        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                Area = ComputeArea();
            }
        }
        public override double ComputeArea()
        {
            return a * b * Math.PI;
        }
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
            Area = ComputeArea();
        }

        public override string ToString()
        {
            return String.Format("Ellipse with area = {0}, a = {1}, b = {2}", Area, a, b);
        }

    }
}
