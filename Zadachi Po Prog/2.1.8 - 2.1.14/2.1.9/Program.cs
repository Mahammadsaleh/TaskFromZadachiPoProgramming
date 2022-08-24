using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int[] arr1;
            int[] arr2;
            AddElements(out n1, out n2, out arr1, out arr2);
            ScalarProduct(n1, n2, arr1, arr2);
            Console.ReadKey();
        }

        private static void ScalarProduct(int n1, int n2, int[] arr1, int[] arr2)
        {
            int product = 0;
            int sumOfProduct = 0;
            if (n1 < n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    product = arr1[i] * arr2[i];
                    sumOfProduct = sumOfProduct + product;
                }
            }
            if (n1 > n2)
            {
                for (int i = 0; i < n2; i++)
                {
                    product = arr1[i] * arr2[i];
                    sumOfProduct = sumOfProduct + product;
                }
            }
            Console.WriteLine("scalar product of array : " + sumOfProduct);
        }

        private static void AddElements(out int n1, out int n2, out int[] arr1 , out int[] arr2)
        {
            Console.Write("Enter the num for range of array : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in first array");
            arr1 = new int[n1];           
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the num for range of 2nd array : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            arr2 = new int[n2];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
