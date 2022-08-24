using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._8___2._1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            AddElements(out n, out arr);
            //Comparison(n, arr);          
            //TotalOfMaxBetweenMax(arr);
            //BeforeMinRatio(arr);
            BetweenAverageMaxAndMiddle(n, arr);
            //Print(arr);
            Console.ReadKey();
        }

        private static void BetweenAverageMaxAndMiddle(int n, int[] arr)
        {
            int max = arr.Max();
            int p = Array.IndexOf(arr, max);
            int middle = (n / 2) ;
            int sum = 0;
            int average = 0;
            if (p > middle)
            {
                for (int i = middle + 1; i < p; i++)
                {
                    sum = sum + arr[i];   
                }
                average = sum / (p - middle - 1);
            }
            if (middle > p)
            {
                for (int i = p + 1; i < middle; i++)
                {
                    sum = sum + arr[i];
                }
                average = sum / (middle - p - 1);
            }
            Console.WriteLine("average of nums between middle index and max num index " + average);
        }

        private static void BeforeMinRatio(int[] arr)
        {
            int min = arr.Min();
            int minp = Array.IndexOf(arr, min);
            double multiplicationTotal = 1;
            double sum = 0;
            for (int i = 0; i < minp; i++)
            {
                sum = sum + arr[i];
                multiplicationTotal = multiplicationTotal * arr[i];
            }
            double ratio = sum / multiplicationTotal;
            Console.WriteLine("multiplication ratio of the sum " + ratio);
        }

        private static void TotalOfMaxBetweenMax(int[] arr)
        {
            int max = arr.Max();
            int maxp = Array.IndexOf(arr, max);
            int min = arr.Min();
            int minp = Array.IndexOf(arr, min);
            int multiplicationTotal = 1;
            for (int i = minp + 1; i < maxp; i++)
            {
                multiplicationTotal = multiplicationTotal * arr[i];
            }
            Console.WriteLine("Total:" + multiplicationTotal);
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

        private static void Comparison(int n, int[] arr)
        {
            int max = arr.Max();
            int p = Array.IndexOf(arr, max);
            int sumbefore = 0;
            int sumafter = 0;
            for (int i = 0; i < p; i++)
            {
                sumbefore = sumbefore + arr[i];
            }
            for (int i = p+1; i < n; i++)
            {
                sumafter = sumafter + arr[i];
            }
            if (sumbefore > sumafter)
            {
                Console.WriteLine("before the max element sum greater");
            }
            if (sumbefore < sumafter)
            {
                Console.WriteLine("after the max element sum greater");
            }
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
