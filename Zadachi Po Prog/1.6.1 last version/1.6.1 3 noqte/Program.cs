using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_3_noqte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter range:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            char test = (char)Console.Read();
            for (int i = 0; i < n-1; i++)
            {
                char c = (char)Console.Read();
                if (c == '.')
                {
                    if (c == test)
                    {
                        count++;
                    }
                }
                test = c;  
            }
            if (count == 2)
            {
                Console.Write("3 points have");
            }
            else Console.Write("have not 3 points");
            Console.ReadKey();
        }
    }
}
