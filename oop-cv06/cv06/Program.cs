using cv06.Objects2d;
using cv06.Objects3d;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0;
            double totalSurface = 0;
            double totalVolume = 0;

            Circle circle = new Circle(4);
            Ellipse ellipse = new Ellipse(1,4);
            Rectangle rectangle = new Rectangle(2, 7);
            Triangle triangle = new Triangle(5, 2);

            Cylinder cyllinder = new Cylinder(6, 12);
            Pyramid pyramid = new Pyramid(4, 12);
            RectangularHexahedron rectangularHexahedron = new RectangularHexahedron(4, 3, 5);
            Sphere sphere = new Sphere(3);

            List<GrObject> grObjects = new List<GrObject>
            {
                circle, ellipse, rectangle, triangle, cyllinder, pyramid, rectangularHexahedron, sphere
            };

            foreach (var item in grObjects)
            {
                item.Draw();
                if (item is Object2D)
                {
                    totalArea = totalArea + ((Object2D)item).ComputeArea();
                }
                if (item is Object3D)
                {
                    totalSurface= totalSurface + ((Object3D)item).ComputeSurface();
                    totalVolume = totalVolume + ((Object3D)item).ComputeVolume();
                }
            }
            Console.WriteLine("total area is: {0}, total surface is: {1}, total volume is {2}", totalArea, totalSurface, totalVolume);

            Console.ReadLine();            
        }
    }
}
