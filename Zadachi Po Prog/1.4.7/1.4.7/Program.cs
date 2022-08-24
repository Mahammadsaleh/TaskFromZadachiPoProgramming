using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double range,func, func2, result, result2;
            
            result = 1;
            result2 = 0;
            Console.WriteLine("enter the range of function pls:)");
            range = int.Parse(Console.ReadLine());

            for (int i = 1; i < range + 1; i++)
            {
                func = 1 + ( 1/ Math.Pow(i, i) );
                result = result * func;
                func2 = Math.Pow((1 + 1 / i), range);
                result2 = result2 * func2;  
            }

            Console.WriteLine("\nFunction equal: " + result);
            Console.WriteLine("\nFunction equal: " + result2);
            Console.ReadKey();
        }
    }
}
