using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1
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
                char c =  (char)Console.Read();
                if (c=='+' || c=='*' || c == '-' || c == '/')
                {
                    //array[i] = c;
                    array = array.Concat(new char[] {c}).ToArray();
                    count++;
                }
            }
            Console.WriteLine(String.Join("",array));
            Console.Write(array.Length);
            //Console.Write(count);
            Console.ReadKey();  
        }
    }
}
