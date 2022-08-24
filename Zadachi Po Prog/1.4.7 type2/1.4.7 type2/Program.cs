using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._7_type2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, x, n, k, func, func2, result, result2;
            result = 0;
            result2 = 0;
            int i = 0;
            int j = 0;
            Console.WriteLine("enter the 1st range of function pls:)");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd range of function pls:)");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the a");
            a=double.Parse(Console.ReadLine()); 
            Console.WriteLine("enter the x");
            x = double.Parse(Console.ReadLine());
            

            for (; j < k + 1; j++)
                {

                    func = Math.Pow(a, i) + Math.Pow(x, j);
                    result = result + func;

            }
            for (;i < n + 1; i++)
            {

            }



                Console.WriteLine("\nFunction equal: " + result);
            Console.WriteLine("\nFunction equal: " + result2);
            Console.ReadKey();
        }
    }
}
