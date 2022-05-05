using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Circle : Object2D
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                this.Area = ComputeArea();
            }
        }

        public Circle(double radius)
        {
            this.radius = radius;
            this.Area = ComputeArea();
        }
        public override double ComputeArea()
        {
            return Math.PI * radius * radius;
        }


        public override string ToString()
        {
            return String.Format("Circle with area = {0} and radius = {1}", this.Area, radius);
        }
    }
}
