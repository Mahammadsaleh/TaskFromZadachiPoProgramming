using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            double[] arr = new double[n];
            double[] barr = new double[n];
            double total = 0;
            
            //n-1 mexrec
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                total = total + arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                barr[i] = (total - arr[i]) / (n-1);
            }

            for (int i = 0; i < barr.Length; i++)
            {
                Console.WriteLine(barr[i]);
            }
            Console.ReadKey();
        }
    }
}
