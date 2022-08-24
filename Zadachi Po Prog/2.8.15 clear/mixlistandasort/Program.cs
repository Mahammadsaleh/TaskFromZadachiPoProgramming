using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixlistandasort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10, 5, 7, 5, -5, -6, 4, -7 };
            List<int> numbers1 = new List<int>() { 4, 5, 2, 1, 3, 0, -4, -2, -3, -1, -4, 4, -9 };
            Console.WriteLine("union List: ");
            numbers.AddRange(numbers1);
            WriteList(numbers);

            var negativeNumbers = numbers.Where(n => n < 0);
            List<int> negList = negativeNumbers.ToList();
            var positiveNumbers = numbers.Where(n => n > 0);
            List<int> posList = positiveNumbers.ToList();
            Console.WriteLine("\npositive elements:");
            WriteList(posList);
            Console.WriteLine("\nnegative elements");
            WriteList(negList);
            Console.ReadKey();
        }

        private static void WriteList(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
