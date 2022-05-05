using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class TestComplex
    {
        public const double epsilon = 0.000001;

        public static void Test(Complex actual, Complex expected, string name)
        {
            double testReal = Math.Abs(actual.Real - expected.Real);
            double testImaginary = Math.Abs(actual.Imaginary - expected.Imaginary);
            if  (testReal <= epsilon && testImaginary <= epsilon)
            {
                Console.WriteLine("Test {0}: OK", name);
            }
            else
            {
                Console.WriteLine("test {0}: Failed", name);
                Console.WriteLine("Expected value: {0}", expected);
                Console.WriteLine("actual value: {0}", actual);
                Console.WriteLine("Real part diff: {0}, imaginary part diff: {1}", testReal, testImaginary);
            }
        }
    }
}
