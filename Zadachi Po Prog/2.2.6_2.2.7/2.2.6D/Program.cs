using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._6D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            double[,] matrix;
            Inputting(out row, out col, out matrix);
            Console.WriteLine("Enter the matrix:");
            Checking(row, col, matrix);
            Console.WriteLine("Matrix length" + matrix.GetLength(0));
            Console.WriteLine("Matrix length" + matrix.GetLength(1));
            Console.ReadKey();
        }
        static double ScalarProductOfRows(double[,] matrix, int col, int rowIndexA, int rowIndexB)
        {
            double scalarProduct = 0;
            for (int i = 0; i < col; i++)
            {
                scalarProduct += matrix[i, rowIndexA] * matrix[i, rowIndexB];
            }
            return scalarProduct;
        }
        private static void Checking(int row, int col, double[,] matrix)
        {
            bool statement = true;
            for (int i = 0; i < row; i++)
            {
                double product = 1;
                double scalarProduct = ScalarProductOfRows(matrix, col, i, i);
                if (scalarProduct != 1)
                {
                    statement = false;
                }
                for (int j = 0; j < col; j++)
                {
                    product = ScalarProductOfRows(matrix, col, i, j);
                }
                if (scalarProduct != 0)
                {
                    statement = false;
                    break;
                }

            }
            if (statement)
            {
                Console.WriteLine("This is ortonorminivy matrix.");
            }
            else
            {
                Console.WriteLine("This is not ortonorminivy matrix.");
            }
        }
        private static void Inputting(out int row, out int col, out double[,] matrix)
        {
            Console.WriteLine("Enter the number of row:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of column:");
            col = int.Parse(Console.ReadLine());
            matrix = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
