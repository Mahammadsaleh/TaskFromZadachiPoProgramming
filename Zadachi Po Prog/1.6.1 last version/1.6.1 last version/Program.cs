using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_last_version
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
                if (c == '+' || c == '*' || c == '-' || c == '/')
                {
                    count++;
                }
            }

            Console.Write(count);
            Console.ReadKey();
        }
    }
}
