using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06.Objects3d
{
    class Cylinder : Object3D
    {
        public double r { get; set; }
        public double v { get; set; }
 

        public Cylinder(double r, double v)
        {
            this.r = r;
            this.v = v;
        }
        public override double ComputeSurface()
        {
            return (v * (2 * r * Math.PI)) + 2*(Math.PI * r * r);
        }

        public override double ComputeVolume()
        {
            return (Math.PI * r * r) * v;
        }

        public override void Draw()
        {
            Console.WriteLine("Cylinder with radius r: {0} and height v: {1} with surface: {2} and volume {3}", r, v, ComputeSurface(), ComputeVolume());
        }
    }
}
