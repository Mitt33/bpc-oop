using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Matrix
    {
        private double[,] matArray;
        public Matrix(double[,] matArray)
        {
            this.matArray = matArray;
        }



        public static Matrix operator +(Matrix a, Matrix b)
        {
    
                if (a.matArray.GetLength(0) == b.matArray.GetLength(0) && a.matArray.GetLength(1) == b.matArray.GetLength(1)) {
                    Matrix product = new Matrix(new double[a.matArray.GetLength(0), a.matArray.GetLength(1)]);
                    for (int i = 0; i < a.matArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matArray.GetLength(1); j++)
                        {
                            product.matArray[i,j] = a.matArray[i, j] + b.matArray[i, j];
                        }
                    }
                    return product;
            }
            throw new ArgumentException("size of matrix a and b is not the same");
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.matArray.GetLength(0) == b.matArray.GetLength(0) && a.matArray.GetLength(1) == b.matArray.GetLength(1))
            {
                Matrix product = new Matrix(new double[a.matArray.GetLength(0), a.matArray.GetLength(1)]);
                for (int i = 0; i < a.matArray.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matArray.GetLength(1); j++)
                    {
                        product.matArray[i, j] = a.matArray[i, j] - b.matArray[i, j];
                    }
                }
                return product;
            }
            else
            {
                throw new ArgumentException("size of matrix a and b is not the same");
            }

        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.matArray.GetLength(1) == b.matArray.GetLength(0))
            {
                Matrix product = new Matrix(new double[a.matArray.GetLength(0), b.matArray.GetLength(1)]);
                for (int i = 0; i < a.matArray.GetLength(0); i++)
                {
                    for (int j = 0; j < b.matArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.matArray.GetLength(1); k++)
                        {
                            product.matArray[i, j] += a.matArray[i, k] * b.matArray[k, j];

                        }
                    }
                }
                return product;
            }
            else
            {
                throw new ArgumentException("size of matrix a and b is not the same");
            }
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.matArray.GetLength(0) == b.matArray.GetLength(0) && a.matArray.GetLength(1) == b.matArray.GetLength(1))
            {
                for (int i = 0; i < a.matArray.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matArray.GetLength(1); j++)
                    {
                        if (a.matArray[i, j] != b.matArray[i, j])
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }

                    }
                }
            }
            else
            {
                throw new ArgumentException("size of matrix a and b is not the same");
            }
            return false;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a == b)
            {
                return false;
            }
            return true;
        }

        public static Matrix operator -(Matrix a)
        {
            Matrix product = new Matrix(new double[a.matArray.GetLength(0), a.matArray.GetLength(1)]);
            for (int i = 0; i < a.matArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.matArray.GetLength(1); j++)
                {
                    product.matArray[i, j] = (-1) * a.matArray[i, j];
                }

            }
            return product;
        }

        public double Det()
        {
            if (matArray.GetLength(0) == matArray.GetLength(0) && matArray.GetLength(0) < 3)
            {
                if(matArray.GetLength(0) == 1)
                {
                    return matArray[0, 0];
                }
                else if (matArray.GetLength(0) == 2)
                {
                    return matArray[0, 0] * matArray[1, 1] - matArray[0, 1] * matArray[1, 0];
                }
                else if (matArray.GetLength(0) == 3)
                {
                    return matArray[0, 0] * (matArray[1, 1] * matArray[2, 2] - matArray[1, 2] * matArray[2, 1]) -
                                matArray[0, 1] * (matArray[1, 0] * matArray[2, 2] - matArray[1, 2] * matArray[2, 0]) +
                                matArray[0, 2] * (matArray[1, 0] * matArray[2, 1] - matArray[1, 1] * matArray[2, 0]);
                }
            }
            return Double.NaN;


        }

        /*
                public override string ToString()
                {
                    String text = "";
                    for (int i = 0; i < matArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < matArray.GetLength(1); j++)
                        {
                            text = text + " " + matArray[i,j];
                        }
                        text = text + "\n";
                    }
                    return text;
                }
        */

        public override string ToString()
        {
            StringBuilder matrix = new StringBuilder();
            for (int i = 0; i < matArray.GetLength(0); i++)
            {
                for (int j = 0; j < matArray.GetLength(1); j++)
                {
       
                        matrix.Append(this.matArray[i,j] + " ");
                }
                matrix.AppendLine();

            }
            return matrix.ToString();

        }


        public double[,] MatArray
        {
            get { return matArray; }
            set { matArray = value; }
        }
    }
}
