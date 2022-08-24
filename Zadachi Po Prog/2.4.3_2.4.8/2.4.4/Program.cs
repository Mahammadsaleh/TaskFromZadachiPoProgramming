using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._3_2._4._8
{
    public class Program
    {

       
        public static void Main(string[] args)
        {
            int[] arr = { 12, 16, 20, 40, 50, 70 };
            int[] arr1 = { 13, 14, 21, 41, 51, 71 };
            int[] unionArr = new int[20];
            InsertSortedToUnionArr(arr, arr1, unionArr);
            Console.Write("\nAfter Insertion: ");
            ShowArray(unionArr, 12);
            Console.ReadKey();
        }
        private static void ShowArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void InsertSortedToUnionArr(int[] arr, int[] arr1, int[] unionArr)
        {
            int n = arr.Length;
            int m = arr1.Length;
            int unionLength = n + m;
            int j = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (j = j; j < unionLength; j++)
                {
                    if (arr[i] > arr1[a])
                    {
                        unionArr[j] = arr1[a];
                        if (j == unionLength - 1)
                        {
                            unionArr[j] = arr[i];
                        }
                    }

                    if (arr[i] < arr1[a])
                    {
                        unionArr[j] = arr[i];
                        j++;
                        if (j == unionLength - 1)
                        {
                            unionArr[j] = arr1[i];
                        }
                        break;
                    }
                    if (a < n - 1) { a++; }
                }
            }
        }
    }
}