using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caesar cipher shifts letters in a string. In this cipher, each letter is shifted a certain number of places in the alphabet");
            Console.Write("\nPls enter the number for shifting letter: ");
            int shiftingKey = int.Parse(Console.ReadLine());
            char[] arr = AddElementsToArray();
            ShiftElementForCeasarMethod(shiftingKey, arr);
            PrintArray(arr);
            Console.ReadKey();
        }

        private static void ShiftElementForCeasarMethod(int shift, char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                char letter = arr[i];
                if (arr[i] >= 97 && arr[i] <= 122 )
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                }

                if(arr[i] >= 65 && arr[i] <= 90)
                {
                    letter = (char)(letter + shift);
                    if (letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                }
                arr[i] = letter;
            }
        }
        private static char[] AddElementsToArray()
        {
            Console.Write("Count of letter in your plaintext: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter you text in array");
            char[] arr = new char[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadKey().KeyChar;
            }
            return arr;
        }
        private static void PrintArray(char[] arr)
        {
            Console.Clear();
            Console.WriteLine("This is caesar method encryption of the plaintext");
            Console.WriteLine("Encrypted Data: ");
            Console.WriteLine(string.Join("", arr));
        }
    }
}
