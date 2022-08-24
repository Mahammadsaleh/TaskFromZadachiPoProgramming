using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._4_2._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            int[,] arr = null;
            Get(out row, out column, out arr);
            Write(arr);
            //DevideRowTORowLastNumIfIsNotZero(arr);

            IfColumnFirstNumNegThenSquareColumnElement(arr);

            //DevideMaxAllElements(arr);
            //DevideAllRowNumToRowMinNum(arr);
            Write(arr);
            Console.ReadKey();
        }

        #region
        private static void DevideAllRowNumToRowMinNum(int[,] arr)
        {
            int rowLenght = arr.GetLength(0);
            int columnLenght = arr.GetLength(1);
            int min = arr[0, 0];

            for (int i = 0; i < rowLenght; i++)
            {
                for (int j = 0; j < columnLenght; j++)
                {
                    min = arr[i, 0];
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }

                for (int j = 0; j < columnLenght; j++)
                {
                    arr[i, j] = arr[i, j] / min;
                }
            }
        }

        private static void DevideMaxAllElements(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    arr[i, j] = arr[i, j] / ModuleMax(arr);
                }
            }
        }
        static int ModuleMax(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int max = Math.Abs(arr[0, 0]);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (Math.Abs(arr[i, j]) > max)
                    {
                        max = Math.Abs(arr[i, j]);
                    }
                }
            }
            return max;
        }
        static int ModuleMin(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int min = Math.Abs(arr[0, 0]);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (Math.Abs(arr[i, j]) < min)
                    {
                        min = Math.Abs(arr[i, j]);
                    }
                }
            }
            return min;
        }

        private static void IfColumnFirstNumNegThenSquareColumnElement(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);

            for (int j = 0; j < columnLength; j++)
            {
                if (arr[0, j] < 0)
                {
                    for (int i = 0; i < rowLength; i++)
                    {
                        arr[i, j] = arr[i, j] * arr[i, j];
                    }
                }
            }
        }
        private static void DevideRowTORowLastNumIfIsNotZero(int[,] arr)
        {
            int rowLenght = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            for (int i = 0; i < rowLenght; i++)
            {
                if (arr[i, columnLength - 1] != 0)
                {
                    for (int j = 0; j < columnLength; j++)
                    {
                        arr[i, j] = arr[i, j] / arr[i, columnLength - 1];
                    }
                }
            }
        }

        private static void Get(out int row, out int column, out int[,] arr)
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

        private static void Write(int[,] arr)
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
    }
    #endregion

}
