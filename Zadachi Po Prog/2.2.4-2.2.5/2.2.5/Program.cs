using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            int[,] arr = null;
            int[] vector = null;
            Get(out row, out column, out arr);
            Write(arr);
            //SumOfRowToVector(arr);
            //ProductOfColumnVector(arr);
            //SumOfColumnNegNumVector(arr);
            //ProductOfRowNegNumToVector(arr);
            //NumberOfZeroInRow(arr);
            NumberOfNegInColumn(arr);
            Console.ReadLine();
        }

     
        #region
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
        #endregion
        #region
        private static int[] ProductOfColumnVector(int[,] arr)
        {
            int[] vector;
            int total = 1;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[columnLength];

            for (int j = 0; j < columnLength; j++)
            {
                for (int i = 0; i < rowLength; i++)
                {
                    total = total * arr[i, j];
                }
                vector[j] = total;
                total = 1;
            }
            for (int i = 0; i < columnLength; i++)
            {
                Console.Write("Porduct of column elements: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        private static int[] SumOfColumnNegNumVector(int[,] arr)
        {
            int[] vector;
            int sum = 0;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[columnLength];

            for (int j = 0; j < columnLength; j++)
            {
                for (int i = 0; i < rowLength; i++)
                {
                    if (arr[i, j] < 0)
                    {
                        sum = sum + arr[i, j];
                    }
                }
                vector[j] = sum;
                sum = 0;
            }
            for (int i = 0; i < columnLength; i++)
            {
                Console.Write("Sum of negative element in column: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        private static int[] SumOfRowToVector(int[,] arr)
        {
            int[] vector;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[rowLength];
            int sum = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    sum = sum + arr[i, j];
                }
                vector[i] = sum;
                sum = 0;
            }
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("Sum of row: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        private static int[] ProductOfRowNegNumToVector(int[,] arr)
        {
            int[] vector;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[rowLength];
            int total = 1;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        total = total * arr[i, j];
                    }
                }
                vector[i] = total;
                total = 1;
            }
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("Product of negative element in Row: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        private static int[] NumberOfZeroInRow(int[,] arr)
        {
            int[] vector;
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[rowLength];
            int count = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if(arr[i, j] == 0)
                    {
                        count++;
                    }
                }
                vector[i] = count;
                count = 0;
            }
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("Number of zero in row: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        private static int[] NumberOfNegInColumn(int[,] arr)
        {
            int[] vector;
            int count = 0; 
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            vector = new int[columnLength];

            for (int j = 0; j < columnLength; j++)
            {
                for (int i = 0; i < rowLength; i++)
                {
                    if (arr[i, j] < 0)
                    {
                        count++;
                    }
                }
                vector[j] = count;
                count = 0 ;
            }
            for (int i = 0; i < columnLength; i++)
            {
                Console.Write("Number of Neg in Column: {0}", vector[i]);
                Console.WriteLine();
            }

            return vector;
        }
        #endregion
    }
}
