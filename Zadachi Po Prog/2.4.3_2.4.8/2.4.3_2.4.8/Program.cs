using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._3_2._4._8
{
    public class Program
    {
        public static int InsertSorted(int[] arr, int n, int key)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j] == key)
                {
                    return n;
                }
            }
            int i;
            for (i = n - 1; (i >= 0 && arr[i] > key); i--)
            {
                if (arr[i] != key)
                {
                    arr[i + 1] = arr[i];
                }
            }
            arr[i + 1] = key;
            return (n + 1);
        }
        private static void AddElementsInArray(int[] arr, out int n)
        {
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void ShowArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = new int[20];
            int n = 0;
            AddElementsInArray(arr, out n);
            int capacity = arr.Length;
            Console.Write("Input the value to be inserted : ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nBefore Insertion: ");
            ShowArray(arr, n);
            n = InsertSorted(arr, n, key);
            Console.Write("\nAfter Insertion: ");
            ShowArray(arr, n);
            Console.ReadKey();
        }
    }
}

