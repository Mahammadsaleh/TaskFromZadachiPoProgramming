using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            int count;
            EnteringPhase(out words, out count);
            Print(words, count);
        }

        private static void EnteringPhase(out string[] words, out int count)
        {
            words = new string[] { "From", "Chinese", "orale", "Chinese", "From" };
            int k = words.Length;
            count = 0;
            for (int i = 0; i < k - 1; i++)
            {
                if (words[i] == words[k - 1])
                {
                    k--;
                    count++;
                }
            }
        }

        private static void Print(string[] words, int count)
        {
            Console.WriteLine(string.Join(",", words));
            if (count == words.Length / 2)
            {
                Console.WriteLine("it is syimmetrik");
            }
            Console.ReadKey();
        }
    }
}
