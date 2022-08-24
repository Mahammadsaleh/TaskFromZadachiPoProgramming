using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            AddElements(out n, out arr);
            //Del(n, arr);
            //DelZero(n, arr);

            DelRange(n, arr);
        }

        private static void DelRange(int n, int[] arr)
        {
            int j = 0;
            Console.Write("enter the beginig point for deleting: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("enter the finish point for deleting: ");
            int n2 = int.Parse(Console.ReadLine());
            int range = Math.Abs( n1 - n2);
            int[] newArr = new int[n - range];
            for (int i = 0; i < range; i++)
            {
                
                    int pos = Array.IndexOf(arr, n1);
                    for (j = pos; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    n1++;

            }

            Console.WriteLine("Array after deletion");
            for (int i = 0; i < n - range; i++)
            {
                newArr[i] = arr[i];
            }

            for (j = 0; j < n - range; j++)
            {
                Console.WriteLine(newArr[j]);
            }
            Console.ReadKey();
        }

        private static void DelZero(int n, int[] arr)
        {
            int j;
            int delnum = 0;
            int pos = Array.IndexOf(arr, delnum);
            int[] newarr = new int[n - 1];
            for (j = pos; j < n - 1; j++)
            {
                arr[j] = arr[j + 1];
            }
            Console.WriteLine("Array after deletion");
            for (int i = 0; i < n - 1; i++)
            {
                newarr[i] = arr[i];
            }

            for (j = 0; j < n - 1; j++)
            {
                Console.WriteLine(newarr[j]);
            }
            Console.ReadKey();
        }

        private static void AddElements(out int n, out int[] arr)
        {
            Console.Write("Enter the num for range of array : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void Del(int n, int[] arr)
        {
            int j;
            Console.Write("Enter the count of num for removing : ");
            int n1 = int.Parse(Console.ReadLine());
            int[] newarr = new int[n - n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter the num for removing: ");
                int delnum = int.Parse(Console.ReadLine());
                int pos = Array.IndexOf(arr, delnum);
                for (j = pos; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
            }

            Console.WriteLine("Array after deletion");
            for (int i = 0; i < n - n1; i++)
            {
                newarr[i] = arr[i];
            }

            for (j = 0; j < n - n1; j++)
            {
                Console.WriteLine(newarr[j]);
            }
            Console.ReadKey();
        }
    }
}
