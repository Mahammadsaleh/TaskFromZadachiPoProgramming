using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;
            int[,] newArr = new int[20, 20];
            int[,] newArr2 = new int[20, 20];
            Get(out m, out n, out a);
            Write(m, n, a);
            DevideLastForNewMatris(m, n, a, newArr);
            Write(m, n, newArr);
            NegToZero(m, n, a, newArr2);
            Write(m, n, newArr2);
            Console.ReadKey();
        }

        private static void NegToZero(int m, int n, int[,] a, int[,] newArr2)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = 0;
                    }
                    newArr2[i, j] = a[i, j];
                }
            }
        }

        private static void DevideLastForNewMatris(int m, int n, int[,] a, int[,] newArr)
        {
            double lastElement = Math.Pow(a[m - 1, n - 1], 2);
            int intLast = Convert.ToInt32(lastElement);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newArr[i, j] = a[i, j] / intLast;
                }
            }
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
