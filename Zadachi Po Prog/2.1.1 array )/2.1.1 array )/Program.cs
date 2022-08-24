using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _2._1._1_array__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string[] arr = new string[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            ArrayList array2 = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (array2.Contains(arr[i]) == false)
                {
                    array2.Add(arr[i]);
                    count++;
                }
                
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(array2[i] + " " );
            }
            String[] forlenghtarray = (String[]) array2.ToArray( typeof( string ) );
            Console.WriteLine("\n"+ forlenghtarray.Length);
            Console.ReadKey();

        }
    }

}
