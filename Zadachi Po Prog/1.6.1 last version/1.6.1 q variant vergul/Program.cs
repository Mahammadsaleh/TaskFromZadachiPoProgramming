using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_q_variant_vergul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                char c = (char)Console.Read();
                if (c == ',')
                {
                    count++;
                }
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
