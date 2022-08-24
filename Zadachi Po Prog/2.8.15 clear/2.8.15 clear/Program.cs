using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8._15_clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1, 2, 5, 7, 8, 10, 5, 7, 5, -5, -6, 4, -7 };
            Console.WriteLine("list as first form: ");
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }

            numbers.RemoveAt(0);

            if (numbers.Count > 1) 
            {
                numbers.RemoveAt(0);
            }

            numbers.RemoveAll(a => a == 5);
            numbers.RemoveAll(a => a < 0);
            Console.WriteLine("\nList after the operation: ");
            foreach (int i in numbers) 
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
            
        }
    }
}
