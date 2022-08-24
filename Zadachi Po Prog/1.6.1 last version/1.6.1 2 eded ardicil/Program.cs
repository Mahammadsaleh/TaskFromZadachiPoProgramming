using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_2_eded_ardicil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter range:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            char test = (char)Console.Read();

            for (int i = 0; i < n - 1; i++)
            {
                char c = (char)Console.Read();
                if (c == test)
                {
                        count++;
                }
                test = c;
                if (count == 1)
                {
                    Console.Write(i+1);
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
