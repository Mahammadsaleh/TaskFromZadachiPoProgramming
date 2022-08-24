using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_j_latin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] array = new char[] { };
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                char c = (char)Console.Read();
                if (c == '\u0061' || c == '\u0062' || c == '\u0063' || c == '\u0064' || c == '\u0065' || c == '\u0066' || c == '\u0067' || c == '\u0068' || c == '\u0069' || c == '\u006A' || c == '\u006B' || c == '\u006C' || c == '\u006D' || c == '\u006E' || c == '\u006F' || c == '\u0071' || c == '\u0072' || c == '\u0073' || c == '\u0074' || c == '\u0075' || c == '\u0076' || c == '\u0078' || c == '\u0079' || c == '\u0070' || c == '\u007A')
                {
                    //array[i] = c;
                    array = array.Concat(new char[] { c }).ToArray();
                    count++;
                }
            }
            Console.WriteLine(String.Join("", array));
            Console.Write(array.Length);
            //Console.Write(count);
            Console.ReadKey();
        }
    }
}
