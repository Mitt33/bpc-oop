using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects3d
{
    class Sphere : Object3D
    {
        public double r { get; set; }

        public Sphere(double r)
        {
            this.r = r;
        }
        public override double ComputeSurface()
        {
            return 4 * Math.PI * r * r ;
        }

        public override double ComputeVolume()
        {
            return (4/3) * Math.PI * r*r*r;
        }

        public override void Draw()
        {
            Console.WriteLine("Sphere with radius r: {0} with surface: {1} and volume {2}", r, ComputeSurface(), ComputeVolume());
        }
    }
}
