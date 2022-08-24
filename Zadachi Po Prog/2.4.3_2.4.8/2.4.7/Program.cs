using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = AddElementsToArray();
            Sort(arr);
            PrintArray(arr);
            Console.ReadKey();
        }
        private static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
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
