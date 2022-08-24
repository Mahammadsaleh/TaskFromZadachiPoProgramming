using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = GetArray();
            int[,] arr1 = GetArray();
            MatrixsProduct(arr, arr1);
            WriteArray(arr);
            Console.ReadKey();
        }

        private static void MatrixsProduct(int[,] arr, int[,] arr1)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    arr[i, j] = arr[i, j] * arr1[i, j];
                }
                Console.WriteLine();
            }
        }
        #region Get and Write Array
        private static int[,] GetArray()
        {

            Console.WriteLine("Enter Row Value");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            int column = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, column];
            Console.WriteLine("Enter Elements one by one");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);

                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        private static void WriteArray(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            Console.WriteLine("Given Matrix");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write("\t{0}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
