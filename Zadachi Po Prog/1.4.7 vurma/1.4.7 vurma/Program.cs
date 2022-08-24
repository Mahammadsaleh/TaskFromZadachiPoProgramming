using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._7_vurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, n, k, func,fact, result, result2;
            fact = 1;
            result = 1;
            result2 = 1;
            int i = 0;
            int j = 0;
            Console.WriteLine("enter the 1st range of function pls:)");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd range of function pls:)");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the x");
            x = double.Parse(Console.ReadLine());

            for (; j < k + 1; j++)
            {
                fact = fact * i;
            }
            result = fact + k*(x/(i+2));
            
            for (; i < n ; i++)
            {
                func =  (x / (i + 2));
            }

            result2 = (n * fact) + (x / (i + 2));
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
