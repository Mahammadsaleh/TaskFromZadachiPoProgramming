using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._12_2._2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = GetArray();
            WriteArray(arr);
            Console.WriteLine("2.2.12 task swap max element to the end index of matrix");
            SwapRow(arr);
            SwapColumn(arr);
            WriteArray(arr);
            Console.ReadKey();
        }
        private static void SwapRow(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            Console.WriteLine("Enter 1st Row that want to swap");
            int row1 = IndexOfRow(arr);
            int row2 = rowLength-1;
            int forSave = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    forSave = arr[row2, j];
                    arr[row2, j] = arr[row1, j];
                    arr[row1, j] = forSave;
                }
            }
        }
        private static void SwapColumn(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            Console.WriteLine("Enter 1st Row that want to swap");
            int column1 = IndexOfColumn(arr);
            int column2 = columnLength - 1;
            int forSave = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    forSave = arr[i, column2];
                    arr[i, column2] = arr[i, column1];
                    arr[i, column1] = forSave;
                }
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
        #region Find Indexs
        private static int IndexOfRow(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int row = 0;
            int max = arr[0, 0];
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        row = i;
                    }
                }
            }
            return row;
        }
        private static int IndexOfColumn(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int column = 0;
            int max = arr[0, 0];
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        column = j;
                    }
                }
            }
            return column;
        }
        #endregion
    }
}
