using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int column, row;
            int[,] arr;
            GetArray(out row, out column, out arr);
            int[] sumArr = new int[row];
            SumRowOfMatrix(arr, sumArr);
            PrintArray(sumArr);

            Console.ReadKey();
        }
        #region Get and Write Array
        private static void SumRowOfMatrix(int[,] arr, int[] sumArr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    sum = sum + arr[i, j];
                }
                sumArr[i] = sum;
                Console.WriteLine();
            }
        }
        private static void GetArray(out int row, out int column, out int[,] arr)
        {

            Console.WriteLine("Enter Row Value");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            column = int.Parse(Console.ReadLine());
            arr = new int[row, column];
            Console.WriteLine("Enter Elements one by one");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);

                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void Write2dArray(int[,] arr)
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
        //private static void SwapRow(int[,] arr)
        //{
        //    int rowLength = arr.GetLength(0);
        //    int columnLength = arr.GetLength(1);
        //    Console.WriteLine("Enter 1st Row that want to swap");
        //    //int row1 = IndexOfRow(arr);
        //    int row2 = rowLength - 1;
        //    int forSave = 0;

        //    for (int i = 0; i < rowLength; i++)
        //    {
        //        for (int j = 0; j < columnLength; j++)
        //        {
        //            forSave = arr[row2, j];
        //            arr[row2, j] = arr[row1, j];
        //            arr[row1, j] = forSave;
        //        }
        //    }
        //}
    }
}
