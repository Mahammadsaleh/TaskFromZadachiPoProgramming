using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            AddElements(out n, out arr);
            int countForIn = 0;
            int countForDe = 0;
            CheckIncOrDec(n, arr, ref countForIn, ref countForDe);
            LengthOfVector(n, arr);
            Console.ReadKey();


        }

        private static void LengthOfVector(int n, int[] arr)
        {
            double pow = 0;
            double length = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                pow =arr[i]*arr[i];
                length = length+pow;
                sum = Math.Sqrt(length);
            }
            Console.WriteLine("length of vector : " + sum);
        }

        private static void CheckIncOrDec(int n, int[] arr, ref int countForIn, ref int countForDe)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    countForDe++;
                }
                else if (arr[i] > arr[i - 1])
                {
                    countForIn++;
                }
            }
            if (countForIn == n - 1)
            {
                Console.WriteLine("increasing");
            }
            else if (countForDe == n - 1)
            {
                Console.WriteLine("decreasing");
            }
            else
                Console.WriteLine("neither increasing nor decreasing");
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
    }
}
