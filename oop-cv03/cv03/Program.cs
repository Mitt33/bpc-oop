using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a1 = new double[,] { { 4, 8 }, { 3, 4 } };
            Matrix m1 = new Matrix(a1);
            double[,] a2 = new double[,] { { 1, 3 }, { 4, 4 } };
            Matrix m2 = new Matrix(a2);
            double[,] a3 = new double[,] { { 4, 8, 2 }, { 1, 3, 4 } };
            Matrix m3 = new Matrix(a3);
            double[,] a4 = new double[,] { { 3, 1, 3 }, { 2, 4, 4 } };
            Matrix m4 = new Matrix(a4);
            double[,] a5 = new double[,] { { 3, 1, 3 }, { 2, 4, 4 },{ 1, 2, 3 } };
            Matrix m5 = new Matrix(a4);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.WriteLine(m1 == m1);
            Console.WriteLine(m1 == m2);
            Console.WriteLine(m1 != m1);
            Console.WriteLine(m1 != m2);
            Console.WriteLine("\n" + -m1);

            Console.WriteLine(m1.Det());
            Console.WriteLine(m5.Det());
            Console.ReadLine();
        }
    }
}
