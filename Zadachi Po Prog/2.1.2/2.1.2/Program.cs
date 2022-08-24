using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double func, result;
            result = 0;
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n+1];

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                func = (Math.Pow(-1, i) * arr[i]);
                result = result+ func;
            }

            Console.WriteLine("\nFunction equal: " + result);
            Console.ReadKey();
        }
    }
}
