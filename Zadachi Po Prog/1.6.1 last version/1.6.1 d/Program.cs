using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] array = new char[] { };
            char test = (char)Console.Read();
            int count = 0;
            for (int i = 0; i < n-1; i++)
            {
                char c = (char)Console.Read();
                if (c == test)
                {   
                    array = array.Concat(new char[] { c }).ToArray();
                }
                test = c;
            }
            Console.WriteLine(String.Join("", array));
            Console.ReadKey();
            
        }
    }
}
