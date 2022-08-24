using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;

            Get(out m, out n, out a);
            Write(m, n, a);
            FindDiagSumRight(m, n, a);
            FindDiagSumLeft(m, n, a);
            FindNorm1(m, n, a);
            Console.ReadKey();
        }

        private static void Get(out int m, out int n, out int[,] a)
        {
           
            Console.WriteLine("Enter Row Value");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            n = int.Parse(Console.ReadLine());
            a = new int[m+1, n+1];
            Console.WriteLine("Enter Elements one by one");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);

                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void Write(int m, int n, int[,] a)
        {
            Console.WriteLine("Given Matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        private static void FindDiagSumRight(int m, int n, int[,] a)
        {
            int d = 0;
            if (m == n)
            {
                for (int i = 0; i < m; i++)
                {

                   
                       
                        
                            d = d + a[i, i];
                        

                   
                }
                Console.WriteLine("Diagonal Sum= {0}", d);
            }
            else
            {
                Console.WriteLine("Can't Perform Diagonal Sum");
            }
        }

        private static void FindDiagSumLeft(int m, int n, int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                m = m - 1;
                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + a[i, j];
                    }

                }
            }
            Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);

        }

        private static void FindNorm1(int m, int n, int[,] a)
        {
            int[] arr = new int[n];
            int sum = 0;
            int j = 0;
            while (n != j)
            {
                for (int i = 0; i < m; i++)
                {
                    sum = sum + a[i, j];
                }
                arr[j] = sum;
                sum = 0;
                j++;
            }
            int max = arr.Max();
            Console.WriteLine("norm =" + max);
        }
    }
}
