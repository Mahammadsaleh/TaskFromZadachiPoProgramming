using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sual_3musbet_ededler_qonsulugu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > 0 && b>0)
                {
                    counter++;
                }
                
                b = a;
            }

            Console.WriteLine($"number of couple: {counter}"); 
            
            Console.ReadKey();
        }
    }
}
