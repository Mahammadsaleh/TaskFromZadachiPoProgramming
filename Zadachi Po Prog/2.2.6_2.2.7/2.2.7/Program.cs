using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._7
{
    internal class Program
    {
      
       
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];

            Console.WriteLine("Given Matrix");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i,j]=i*j;
                    Console.Write("\t"+arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }
}
