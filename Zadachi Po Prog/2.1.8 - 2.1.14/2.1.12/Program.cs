using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._12
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //string text = "From Chinese oracle bones recording the names of Shang-dynasty rulers more than 3000 years ago, to Magna Carta in 1215 and the ultimatum letter which signalled the beginning of World War Two, the British Library’s collection contains a wealth of documents, letters and charters, that mark some of the most iconic and important events in the world’s political, legal and social history. On 11 February 1225, King Henry III issued what became the final and definitive version of Magna Carta.";
            //string[] words = text.Split(' ');
            string[] words = new string[80] { "From", "Chinese", "oracle", "bones", "recording", "the", "names", "of", "Shang-dynasty", "rulers", "more", "than", "3000", "years", "ago,", "to", "Magna", "Carta", "in", "1215", "and", "the", "ultimatum", "letter", "which", "signalled", "the", "beginning", "of", "World", "War", "Two,", "the", "British", "Library’s", "collection", "contains", "a", "wealth", "of", "documents,", "letters", "and", "charters,", "that", "mark", "some", "of", "the", "most", "iconic", "and", "important", "events", "in", "the", "world’s", "political,", "legal", "and", "social", "history.", "On", "11", "February", "1225,", "King", "Henry", "III", "issued", "what", "became", "the", "final", "and", "definitive", "version", "of", "Magna", "Carta." };
            int k = words.Length - 1;
            for (int i = k; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }
        
    }
}
