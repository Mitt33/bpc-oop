using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects3d
{
    class Pyramid : Object3D
    {
        public double a { get; set; }
        public double v { get; set; }

        public Pyramid(double a, double v)
        {
            this.a = a;
            this.v = v;
        }
        public override double ComputeSurface()
        {
            return (a * a) + (2 * a * Math.Sqrt((a / 2) * (a / 2) + (v * v)));
        }

        public override double ComputeVolume()
        {
            return (1 / 3) * a * a * v;
        }

        public override void Draw()
        {
            Console.WriteLine("Pyramid with site a: {0} a nd height v: {1} with surface: {2} and volume {3}", a, v, ComputeSurface(), ComputeVolume());
        }
    }
}
