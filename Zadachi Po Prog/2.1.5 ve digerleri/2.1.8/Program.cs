using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr.Max();
            int p = Array.IndexOf(arr, max);
            
            for (int j = 0; j < arr.Length; j=j+2)
            {
                int change = max * arr[j];
                (arr[j]) = change;
            }

            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }
    }
}
