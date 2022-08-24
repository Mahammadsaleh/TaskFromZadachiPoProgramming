using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = AddElementsToArray();
            bubbleSort(arr);    
            PrintArray(arr);
            Console.ReadKey();
        }
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }
        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        private static int[] AddElementsToArray()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
