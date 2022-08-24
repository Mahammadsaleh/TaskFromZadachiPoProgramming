using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._3_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    counter++;
                }

                if (counter == 2)
                    continue;

                if (counter==1)
                {
                    sum = sum + arr[i];
                }

            }
            
            Console.WriteLine("sum of array between 2 zeroes: "+sum); 
            Console.ReadKey();
        }
    }
}
