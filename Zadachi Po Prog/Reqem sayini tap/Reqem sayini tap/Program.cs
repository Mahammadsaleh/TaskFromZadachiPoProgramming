using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqem_sayini_tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, counter,powtest;
            counter = 0;
            powtest = 0;
            Console.WriteLine("enter the number:)");
            n = int.Parse(Console.ReadLine());
            if (n != 1) 
            {
                powtest = n;
            }
            if (n != 0)
            {
                while (n > 0)
                {
                    n = n / 10;
                    counter++;
                }
            }
            else counter = 1;

            Console.WriteLine("number of digits:" + counter);

            while (powtest%3==0)
            {
                powtest = powtest / 3;
            }

            if (powtest == 1 )
            {
                Console.WriteLine("and also thıs number is a power of 3");
            }
            Console.ReadKey();
        }
    }
}
