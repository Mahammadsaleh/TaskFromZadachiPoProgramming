using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PowerModuleA();
            //FirstIndexNeg();
            //RearRange();
            //AvarageToMin();
        }

        private static void AvarageToMin()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr.Min();
            int p = Array.IndexOf(arr, min);
            int total = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                total = total + arr[j];
            }
            int avarage = total / arr.Length;

            (arr[p]) = avarage;
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }
        private static void FirstIndexNeg()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr[0] < 0)
            {
                for (int i = 1; i < arr.Length; i++)
                {

                    if (arr[i] < 0)
                    {
                        int multiplication = arr[0] * arr[i];
                        arr[i] = multiplication;
                    }

                    if (arr[0] > 0)
                    {
                        Console.WriteLine("This func not working for this statement");
                    }
                }
            }
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }
        private static void PowerModuleA()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    int power = arr[i] * arr[i];
                    (arr[i]) = power;
                }

                if (arr[i] < 0)
                {
                    int module = Math.Abs(arr[i]);
                    (arr[i]) = module;
                }
            }
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }
        static void RearRange()
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int j = 0, temp;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }

    }
}
