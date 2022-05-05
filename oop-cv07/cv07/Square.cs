using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Square : Object2D
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

        public Square(double a)
        {
            this.a = a;
            Area = ComputeArea();
        }
        public override double ComputeArea()
        {
            return a*a;
        }


        public override string ToString()
        {
            return String.Format("Square with area = {0} and site = {1}", Area, a);
        }
    }
}
