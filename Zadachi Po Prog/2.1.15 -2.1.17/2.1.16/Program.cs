using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            int m;
            int[] arr2;
            AddElements(out n, out arr);
            AddElementsFor2nd(out m, out arr2);
            FlagForPositiveCount(n, arr, m, arr2);
            SumMinFlag(n, arr, m, arr2);
            Console.ReadKey();
        }

        private static void SumMinFlag(int n, int[] arr, int m, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sum1 = sum1 + arr[i];
                }

            }
            for (int i = 0; i < m; i++)
            {
                if (arr2[i] < 0)
                {
                    sum2 = sum2 + arr[i];
                }

            }
            if (sum1 < sum2)
            {
                flag = true;
            }
            Console.WriteLine(flag);
        }

        private static void FlagForPositiveCount(int n, int[] arr, int m, int[] arr2)
        {
            bool flag = false;
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                if (arr2[i] > 0)
                {
                    count2++;
                }
            }
            if (count > count2)
            {
                flag = true;
            }
            Console.WriteLine(flag);
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
        private static void AddElementsFor2nd(out int m, out int[] arr2)
        {
            Console.Write("Enter the num for range of 2nd array : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in 2nd array");
            arr2 = new int[m];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
