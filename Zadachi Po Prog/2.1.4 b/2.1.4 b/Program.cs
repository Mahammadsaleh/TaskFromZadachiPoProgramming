using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._4_b
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
            int temp;
            Console.WriteLine("enter k for right or left side ");
            Console.WriteLine("if enter 0 --> right side if enter 1 --> left side ");
            int k = int.Parse(Console.ReadLine());
            if (k==0)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    temp = arr[0];
                    arr[0] = arr[j + 1];
                    arr[j + 1] = temp;
                }
                Console.WriteLine("Array Elements After Right Circular Rotation: ");
            }
            if (k==1)
            {
                temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp;
                Console.WriteLine("Array Elements After Left Circular Rotation: ");
            }
            
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
