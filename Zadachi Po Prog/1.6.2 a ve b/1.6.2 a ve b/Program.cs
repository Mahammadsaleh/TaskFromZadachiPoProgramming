using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._2_a_ve_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[] array = new char[] { };
            int count1 = 0;
            int count2 = 0;
            bool f = true;
            Console.WriteLine("funksiya a nin  b den boyuk oldugu halda isleyir!!" +
                "saylar beraberlesende funksiya dayanir");
            while (f)
            {
                char c = (char)Console.Read();
                if (c == 'a' )
                {
                    array = array.Concat(new char[] { c }).ToArray();
                    count1++;
                }
                if (c == 'b')
                {
                    array = array.Concat(new char[] { c }).ToArray();
                    count2++;
                }
                if (count1 > count2) { f = true; }
                else { f = false; }
            }
            
            Console.Write($"a sayi{ count1},b sayi{ count2}");
            //Console.Write(count);
            Console.ReadKey();
        }
    }
}
