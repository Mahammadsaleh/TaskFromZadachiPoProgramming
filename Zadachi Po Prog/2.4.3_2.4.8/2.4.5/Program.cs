using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = AddElementsToArray();
            sort(arr);
            PrintArray(arr);    
            Console.ReadKey();
        }
        static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int max_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[max_idx])
                    {
                        max_idx = j;
                    }
                }
                int temp = arr[max_idx];
                arr[max_idx] = arr[i];
                arr[i] = temp;
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
                arr[i] =  int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
