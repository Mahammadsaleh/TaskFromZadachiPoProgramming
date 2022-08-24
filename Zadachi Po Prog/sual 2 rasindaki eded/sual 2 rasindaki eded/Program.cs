using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sual_2_rasindaki_eded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nece eded yazmaq isteyirsiniz?");
            int n = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double a = 0;
            int counter = 0;
            int Result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                counter++;//indexden 1 eksik
                int index = counter + 1;//orginal index

                a = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    if (b <= index && a > index)
                    {
                        Result = index;
                    }
                }
                b = a;
                
            }
            Console.WriteLine("x in indeksi:");
            Console.WriteLine(Result);//yalnizca sonda olan indexi verir
            Console.ReadKey();
        }
    }
}
