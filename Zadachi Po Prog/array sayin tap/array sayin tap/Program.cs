using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_sayin_tap
{
    internal class Program
    {

        public static void countFreq(int[] arr, int n)
        {
            
            bool[] visited = new bool[n];

            // Traverse through array elements and
            // count frequencies
            for (int i = 0; i < n; i++)
            {

                // Skip this element if already processed
                if (visited[i] == true)
                    continue;

                // Count frequency
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " ---> " + count+" times repeating");
            }
        }
        public static void onenumeach(int[] arr, int n)
        {
            int count = 0;
            ArrayList array2 = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (array2.Contains(arr[i]) == false)
                {
                    array2.Add(arr[i]);
                    count++;
                }

            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(array2[i] + " ");
            }

        }
        public static void ifexsistcouple(int[] arr, int n)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {




                if (arr[i] == arr[i - 1])
                {

                    count++;
                }

            }
            if (count > 0)
            {
                Console.WriteLine("it has same couple");
            }



        }
        public static void ifgreatercouple(int[] arr, int n)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                
                    if (arr[i] < arr[i-1])
                    {
                        count++;
                    }

            }
                Console.WriteLine("first one greater than 2nd one  couple num : "+count);

        }


        public static void findduplicatecount(int[] arr, int n)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate)
                {
                    counter++;
                }
            }
            Console.WriteLine("Unique elements of array=" + counter);
            Console.ReadKey();



        }
        public static void numofchanges(int[] arr, int n)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    double b = Math.Abs(arr[i]) / Math.Abs(arr[i - 1]);
                    if (arr[i] == (-1) * b * arr[i - 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine("The number of sign changes in the array=" + counter);
            
        }
            // Driver code
            public static void Main(String[] args)
        {
            Console.Write("Enter the num for range of array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num in array");
            int[] arr = new int[n];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //numofchanges(arr, n);
            //Console.ReadKey();
            ifgreatercouple(arr, n);
            Console.ReadKey();
            findduplicatecount(arr,n);
            Console.ReadKey();
            ifexsistcouple(arr, n);
            Console.ReadKey();
            Console.WriteLine("It will show how many of each digit exist on array\n downloading....");
            System.Threading.Thread.Sleep(1000);
            countFreq(arr, n);
            Console.ReadKey();
            Console.WriteLine("press enter");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("This function show different array items");
            onenumeach(arr, n);
            Console.ReadKey();
        }
    }
}
