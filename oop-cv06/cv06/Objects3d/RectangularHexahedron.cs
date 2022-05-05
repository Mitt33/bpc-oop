using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects3d
{
    class RectangularHexahedron : Object3D
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public RectangularHexahedron(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double ComputeSurface()
        {
            return 2 * (a * b + b * c + a * c);
        }

        public override double ComputeVolume()
        {
            return a * b * c;
        }

        public override void Draw()
        {
            Console.WriteLine("Cuboid with site a: {0}, b: {1} and c: {2} with surface: {3} and volume {4}", a, b, c, ComputeSurface(), ComputeVolume());
        }
    }
}
