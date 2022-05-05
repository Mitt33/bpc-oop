using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Rectangle : Object2D
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
                this.Area = ComputeArea();

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
                this.Area = ComputeArea();
            }
        }
        public override double ComputeArea()
        {
            return a * b;
        }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.Area = this.ComputeArea();
        }

        public override string ToString()
        {
            return String.Format("rectangle with area = {0}, a = {1}, b = {2}", this.Area, a, b);
        }



    }
}
