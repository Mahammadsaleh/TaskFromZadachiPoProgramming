using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2.2.14 product of Vector and Matrix");
            int[,] arr = GetArray();
            int[] vector = AddElements();
            WriteArray(arr);
            Console.WriteLine("Given Vector");
            Console.WriteLine(string.Join(",", vector));
            ProductOfVecAndMatrix(arr, vector);
            WriteArray(arr);
            Console.ReadKey();
        }

        private static void ProductOfVecAndMatrix(int[,] arr, int[] vector)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);

            int ivector = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    arr[i, j] = arr[i, j] * vector[ivector];
                    ivector++;
                }
                Console.WriteLine();
            }
        }

        private static int[] AddElements()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int []vector = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        #region Get and Write Matrix
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
