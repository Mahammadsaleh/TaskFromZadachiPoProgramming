using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] arr;
            int m;
            int[] arr2;
            AddElements(out n, out arr);
            //AddElements(out m, out arr2);
            AVariant(n, arr);
            //BVariant(n, arr);
            //CVar(n, arr);
            Console.ReadKey();
        }

        private static void CVar(int n, int[] arr)
        {
            int max = arr.Max();
            int maxp = Array.IndexOf(arr, max);

            for (int i = maxp; i < n; i++)
            {
                arr[i] = max;
            }
            Console.WriteLine(string.Join(",", arr));
        }

        private static void BVariant(int n, int[] arr)
        {
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    index = i;
                    break;
                }

            }
            for (int i = 0; i < index; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine(string.Join(",", arr));
        }

        private static void AVariant(int n, int[] arr)
        {
            n = arr.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= 1 && arr[i] >= 0)
                {
                    count++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    if (count > 0)
                    {
                        arr[i] = 0;
                    }
                    else
                    {
                        arr[i] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(",", arr));
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
