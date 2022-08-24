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
            GetArray(out row,out column,out arr);
            int[] sumArr = new int[row];
            SumRowOfMatrix(arr,sumArr);
            SwapRow(arr,ref sumArr);
            Write2dArray(arr);
            
            Console.ReadKey();
        }
  
        private static void SumRowOfMatrix(int[,] arr, int[] sumArr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    sum= sum+arr[i,j];  
                }
                sumArr[i] = sum;
                sum = 0;
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

        private static void SwapRow(int[,] arr,ref int[] sumArr)
        {

            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int forSave = 0;
            int min_idx = Array.IndexOf(sumArr, sumArr.Min());

            for (int a = 0; a < rowLength-1 ; a++)
            {
             
                if (sumArr[a] > sumArr[a + 1])
                {
                    for (int i = 0; i < rowLength-1; i++)
                    {
                        for (int j = 0; j < columnLength; j++)
                        {
                            forSave = arr[i+1, j];
                            arr[i+1, j] = arr[i, j];
                            arr[i, j] = forSave;
                        }
                    }
                }
            }
            //for (int i = 0; i < rowLength - 1; i++)
            //{
            //    // Find the minimum element in unsorted array
            //    int min_idx = i;
            //    for (int j = i + 1; j < rowLength; j++)
            //    {

            //        if (sumArr[j] < sumArr[min_idx])
            //        {
            //            min_idx = j;
            //        }
            //    }
            //    // Swap the found minimum element with the first
            //    // element
            //    int temp = sumArr[min_idx];
            //    sumArr[min_idx] = sumArr[i];
            //    sumArr[i] = temp;
            //}
        }
    }
}
