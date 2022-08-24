using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._4_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];
            int i = 0;  
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int j = arr.Length - 1;  
            int b = 0;
            while (b < j)
            {
                var temp = arr[b];
                arr[b] = arr[j];
                arr[j] = temp;
                b++;
                j--;
            }
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();  
        }
    }
}
