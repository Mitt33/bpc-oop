using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3.3, 1.2);
            Complex c2 = new Complex(3.8, 10.2);
            TestComplex.Test(c1 + c2, new Complex(7.1, 11.4), "test +");
            TestComplex.Test(c1 - c2, new Complex(-0.5, -9), "test -");
            TestComplex.Test(c1 * c2, new Complex(4.3, 17.8), "test *");
            TestComplex.Test(c1 / c2, new Complex(1.13892, 0.1007), "test /");
            TestComplex.Test(-c1, new Complex(-3.3, -1.2), "test unary -");
            TestComplex.Test((c1).Conjugate(), new Complex(3.3, -1.2), "test conjugate");


            Console.WriteLine("{0} == {1}: {2}", c1, c2, c1 == c2);
            Console.WriteLine("{0} != {1}: {2}", c1, c2, c1 != c2);
       
            Console.WriteLine("Modul {0}: {1}", c1, c1.Modul());
            Console.WriteLine("Argument {0}: {1}", c1, c1.Argument());


            Console.ReadLine();

        }
    }
}
