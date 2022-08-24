using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            char[] chArray;
            TextEntering(out text, out chArray);
            Print(text, chArray);
            Console.ReadKey();
        }

        private static void TextEntering(out string text, out char[] chArray)
        {
            text = "From Chinese oracle bones recording the names of Shang-dynasty rulers more than 3000 years ago, to Magna Carta in 1215 and the ultimatum letter which signalled the beginning of World War Two, the British Library’s collection contains a wealth of documents, letters and charters, that mark some of the most iconic and important events in the world’s political, legal and social history. On 11 February 1225, King Henry III issued what became the final and definitive version of Magna Carta.";
            //string[] text = new string[80] { "From", "Chinese", "oracle", "bones", "recording", "the", "names", "of", "Shang-dynasty", "rulers", "more", "than", "3000", "years", "ago,", "to", "Magna", "Carta", "in", "1215", "and", "the", "ultimatum", "letter", "which", "signalled", "the", "beginning", "of", "World", "War", "Two,", "the", "British", "Library’s", "collection", "contains", "a", "wealth", "of", "documents,", "letters", "and", "charters,", "that", "mark", "some", "of", "the", "most", "iconic", "and", "important", "events", "in", "the", "world’s", "political,", "legal", "and", "social", "history.", "On", "11", "February", "1225,", "King", "Henry", "III", "issued", "what", "became", "the", "final", "and", "definitive", "version", "of", "Magna", "Carta." };
            //char[] chArray = new char[] {};
            string[] text1 = new string[] { };
            chArray = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                chArray[i] = text[i];
            }
        }

        private static void Print(string text, char[] chArray)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (chArray[i] >= 48 && chArray[i] <= 57)
                {
                    Console.Write(text[i]);

                }

            }
            Console.Write(" ");
            for (int i = 0; i < text.Length; i++)
            {
                if (!(chArray[i] >= 48 && chArray[i] <= 57))
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
