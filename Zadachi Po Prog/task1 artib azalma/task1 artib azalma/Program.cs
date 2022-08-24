using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_artib_azalma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n=int.Parse(Console.ReadLine());
            double a=double.Parse(Console.ReadLine());
            double b = 0;
            b = a;
            int counterIncreasing = 0;
            int counterDecreasing = 0;

            for (int i = 0; i < n-1; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a>b)
                {
                    counterIncreasing++;
                }
                if (b>a)
                {
                    counterDecreasing++;
                }
                b = a;
            }
            if (counterIncreasing==(n-1))
            {
                Console.WriteLine("increasing");
            }
            else if (counterDecreasing==(n-1))
            {
                Console.WriteLine("decreasing");
            }
            else
            {
                Console.WriteLine("neither increasing nor decreasing");
            }

            Console.ReadKey();

        }
    }
}
