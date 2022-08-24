using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;
            int[,] a1;
            Get(out m, out n, out a);
            Write(m, n, a);
            Get(out m, out n, out a1);
            Write(m, n, a1);
            //Power2(m, n, a);
            //TotalOfPos(m, n, a);
            //Power2(m, n, a1);
            //TotalOfPos(m, n, a1);
            Console.WriteLine("Minimum elememnt of Matris: "+Min(m, n, a));
            Console.WriteLine("Minimum elememnt of Matris: " + Min(m, n, a1));
            Max(m, n, a);
            Max(m, n, a1);
            Console.ReadKey();
        }

        private static int Min(int m, int n, int[,] a)
        {
            int small = a[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (small > a[i, j])
                    {
                        small = a[i, j];
                    }
                }
            }
            return small;
        }
        private static void Max(int m, int n, int[,] a)
        {
            int row = 0;
            int column = 0;
            int max = a[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
            Console.WriteLine("index of max - [{0}],[{1}] : ", row, column);
            Console.WriteLine("Maximum elememnt of Matris: " + max);
        }



        private static void TotalOfPos(int m, int n, int[,] a)
        {
            int total = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                    {
                        total = total * a[i, j];
                    }

                }
            }
            Console.WriteLine("total of the postive elements : " + total);
        }

        private static void Power2(int m, int n, int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum = sum + (a[i, j] * a[i, j]);
                }
            }
            Console.WriteLine("sum of to the power of 2" + sum);
        }

        private static void Get(out int m, out int n, out int[,] a)
        {

            Console.WriteLine("Enter Row Value");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            n = int.Parse(Console.ReadLine());
            a = new int[m + 1, n + 1];
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
    }
}
