using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = GetArray();
            int[,] averageArr = null;
            
            Write(arr);
            averageArr = AvarageNeighbourArr(arr);
            Write(averageArr);
            Console.ReadKey();
        }

        private static int[,] AvarageNeighbourArr(int[,] arr)
        {
            int[,] averageArr;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int sum = 0;
            int count = 0;
            averageArr = new int[rowLength, columnLength];

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    // For Shifting to Right,Left,Up,Below
                    if (j != columnLength - 1)
                    {
                        sum += arr[i, j + 1];
                        count++;
                    }

                    if (j >= 1)
                    {
                        sum += arr[i, j - 1];
                        count++;
                    }

                    if (i != rowLength - 1)
                    {
                        sum += arr[i + 1, j];
                        count++;
                    }

                    if (i >= 1)
                    {
                        sum += arr[i - 1, j];
                        count++;
                    }
                    // ------------------
                    if (j != columnLength - 1 && i != rowLength - 1)
                    {
                        sum += arr[i + 1, j + 1];
                        count++;
                    }

                    if (j != 0 && i != rowLength - 1)
                    {
                        sum += arr[i + 1, j - 1];
                        count++;
                    }

                    if (j != columnLength - 1 && i != 0)
                    {
                        sum += arr[i - 1, j + 1];
                        count++;
                    }

                    if (j != 0 && i != 0)
                    {
                        sum += arr[i - 1, j - 1];
                        count++;
                    }

                    averageArr[i, j] = sum / count;
                    count = 0;
                    sum = 0;
                }
            }
            return averageArr;
        }

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
}
