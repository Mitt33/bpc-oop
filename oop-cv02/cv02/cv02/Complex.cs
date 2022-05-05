using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Complex
    {
        private double real;
        private double imaginary;

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public Complex(double real = 0, double imaginary = 0)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.real * b.real - a.imaginary * b.imaginary), (a.real * b.imaginary + a.imaginary * b.real));
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary),
                (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary));
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return (a.real == b.real && a.imaginary == b.imaginary);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a.real == b.real && a.imaginary == b.imaginary);
        }

        public static Complex operator -(Complex a)
        {
            return new Complex(-a.real, -a.imaginary) ;
        }

        public Complex Conjugate()
        {
            return new Complex(real, -imaginary);
        }

        public double Modul()
        {
            return Math.Sqrt(real * real - imaginary * imaginary);
        }

        public double Argument()
        {
            return Math.Atan2(imaginary, real);
        }
        public override string ToString()
        {
            if (imaginary >= 0)
            {
                return string.Format("{0} + {1}j", real, imaginary);
            }
            else
            {
                return string.Format("{0} - {1}j", real, -imaginary);
            }
        }

    }
}
