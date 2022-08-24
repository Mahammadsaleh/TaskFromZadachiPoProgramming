using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cu_sual_0_lar_arasindaki_hasil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            int h = 1;
            int counter = 0;
            bool ifH0 = false;
            int a = int.Parse(Console.ReadLine());
            for (
                int i = 0; i < n-1 ; i++)
            {
                if (a==0)
                {
                    counter++;
                }
                else if  (counter == 1) 
                { 
                    h = h * a;
                }
                b = a;
                a = int.Parse(Console.ReadLine());
                if (a==0 && b==0)
                {
                    ifH0 = true;
                }
                else
                {
                    ifH0 = false;
                }
            }


            if (h!=1)
            {


                if (counter >= 2)
                {
                    Console.WriteLine($"multiply application: {h}");
                }

                else
                {
                    Console.WriteLine("you don't have two zeroes");
                }
            }
            else
            {
                Console.WriteLine("h=0");

            }
            
            Console.ReadKey();
        }
    }
}
