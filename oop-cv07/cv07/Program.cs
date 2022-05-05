using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Smallest and biggest integrers are: ");
            Console.WriteLine(Extremes.Smallest(intArr));
            Console.WriteLine(Extremes.Biggest(intArr));

            String[] stringArr = new String[] { "Hello", "there!", "Obi-wan", "Kenobi?" };
            Console.WriteLine("\nfirst and last strings alphabeticly are: ");
            Console.WriteLine(Extremes.Smallest(stringArr));
            Console.WriteLine(Extremes.Biggest(stringArr));

            Circle[] circleArr = new Circle[] { new Circle(4), new Circle(20), new Circle(2), new Circle(2), new Circle(8) };
            Console.WriteLine("\nSmallest and biggest circles are: ");
            Console.WriteLine(Extremes.Smallest(circleArr));
            Console.WriteLine(Extremes.Biggest(circleArr));

            Rectangle[] rectangleArr = new Rectangle[] { new Rectangle(4, 1), new Rectangle(20, 25), new Rectangle(2,8), new Rectangle(4,2), new Rectangle(11,3) };
            Console.WriteLine("\nSmallest and biggest rectangles are: ");
            Console.WriteLine(Extremes.Smallest(rectangleArr));
            Console.WriteLine(Extremes.Biggest(rectangleArr));

            Square[] squareArr = new Square[] { new Square(4), new Square(25), new Square(8), new Square(2), new Square(3) };
            Console.WriteLine("\nSmallest and biggest squares are: ");
            Console.WriteLine(Extremes.Smallest(squareArr));
            Console.WriteLine(Extremes.Biggest(squareArr));

            Object2D[] object2dArr= new Object2D[] { new Rectangle(4, 1), new Circle(25), new Square( 8), new Traingle(11, 3) };
            Console.WriteLine("\nSmallest and biggest 2d objects are are: ");
            Console.WriteLine(Extremes.Smallest(object2dArr));
            Console.WriteLine(Extremes.Biggest(object2dArr));
            
            Console.WriteLine("\nfilter with linq is: ");
            //Console.WriteLine(intArr.Where(i => i > 4 && i < 8));
            IEnumerable<int> query = intArr.Where(i => i > 4 && i < 8);
            foreach (int number in query)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
