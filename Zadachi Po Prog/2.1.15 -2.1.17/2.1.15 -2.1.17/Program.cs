using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._15__2._1._17
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
            //ZeroCounter(n, arr, m, arr2);
            //SumOfPositive(n, arr, m, arr2);
            //SumOfMin(arr, arr2);
            //DiffMax(arr, arr2);
            SubtractOfArr(n, arr, m, arr2);
            Console.ReadKey();
        }

        private static void SubtractOfArr(int n, int[] arr, int m, int[] arr2)
        {
            int min = Min1(n, arr);
            int min2 = Min2(m, arr2);
            int Subtract = Math.Abs(min - min2);
            Console.WriteLine("subtract of minimum value of positive elements in 2 array : " + Subtract);
        }

        private static int Min2(int m, int[] arr2)
        {
            int min2 = 0;
            int number = 0;
            if (arr2[0] < 0)
            {
                min2 = int.MaxValue;
            }
            else
            {
                min2 = arr2[0];
            }
            for (int i = 1; i < m; i++)
            {
                if (arr2[i] < 0)
                {
                    number = int.MaxValue;
                }
                else
                {
                    number = arr2[i];
                }
                if (number < min2 && min2 > 0)
                {
                    min2 = number;
                }
            }
            return min2;
        }

        private static int Min1(int n, int[] arr)
        {
            int min = 0;
            int number = 0;
            if (arr[0] < 0)
            {
                min = int.MaxValue;
            }
            else
            {
                min = arr[0];
            }
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    number = int.MaxValue;
                }
                else
                {
                    number = arr[i];
                }
                if (number < min && min > 0)
                {
                    min = number;
                }
            }
            return min;
        }

        private static void DiffMax(int[] arr, int[] arr2)
        {
            int max = arr.Max();
            int max2 = arr2.Max();
            if (max > max2)
            {
                Console.WriteLine("first array max num greater than 2nd");

            }
            else if (max < max2)
            {
                Console.WriteLine("2nd array max num greater than first");
            }
        }

        private static void SumOfMin(int[] arr, int[] arr2)
        {
            int min = arr.Min();
            int min2 = arr2.Min();
            int sum = min + min2;
            Console.WriteLine("sum of minumum of arrays" + sum);
        }

        private static void SumOfPositive(int n, int[] arr, int m, int[] arr2)
        {
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    sum = sum + arr[i];
                }
            }
            for (int i = 0; i < m; i++)
            {
                if (arr2[i] > 0)
                {
                    sum2 = sum2 + arr2[i];
                }
            }
            if (sum > sum2)
            {
                Console.WriteLine(sum2);
            }
            else if (sum < sum2)
            {
                Console.WriteLine("sum of positive nums: "+sum);
            }

           
        }

        private static void ZeroCounter(int n, int[] arr, int m, int[] arr2)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    counter++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                if (arr2[i] == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("number of zeroes : " + counter);
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
