using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Traingle : Object2D
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
        private double v;
        public double V
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
                Area = ComputeArea();
            }
        }
        public override double ComputeArea()
        {
            return (a * v) / 2;
        }
        public Traingle(double a, double v)
        {
            this.a = a;
            this.v = v;
            Area = ComputeArea();
        }

        public override string ToString()
        {
            return String.Format("Triangle with area = {0}, a = {1}, v = {2}", Area, a, v);
        }
    }
}
