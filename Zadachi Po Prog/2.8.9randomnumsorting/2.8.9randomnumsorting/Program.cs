using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8._9randomnumsorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We can add num also this ways
            //IEnumerable<int> nums = Enumerable.Range(1, 100);
            //List<int> numbersToHundred = nums.ToList();
            List<int> numbers = new List<int>();
            AddNumToList(numbers,10);
            Console.WriteLine("List which exist numbers 1 to 100:");
            WriteList(numbers);
            Console.WriteLine("\nList after get random numbers (with sorting):");
            List<int> randomNums = GetRandomNums(numbers, 3);
            List<int> myList = new List<int>() {2,5,6};
            randomNums.Sort();
            
            List<int> newList = new List<int>();
            for (int i = 0; i < randomNums.Count-1; i++)
            {
                for (int j = i; j < myList.Count; j++)
                {
                    if (randomNums[i] < myList[j])
                    {
                        newList.Add(randomNums[i]);
                    }
                    if(myList[i] < randomNums[j])
                    {
                        newList.Add(myList[i]);
                    }
                    //newList.Add(randomNums[i]);

                }
                //break when mylist[i] insertr
            }
        
            WriteList(randomNums);
            Console.WriteLine("\n");
            WriteList(newList);
            //randomNums.Sort();
            //WriteList(randomNums);
            //int sum = 0;
            //int average = 0;
            //foreach (int i in randomNums)
            //{
            //   sum =sum + i;
            //}
            //average = sum / 25;
            //Console.WriteLine($"\nAverage:{average}\nSum:{sum}");
            Console.ReadKey();
        }

        private static void AddNumToList(List<int> numbers,int count)
        {
            for (int i = 0; i <= count; i++)
            {
                numbers.Add(i);
            }
        }

        private static List<int> GetRandomNums(List<int> numbers,int count)
        {
            List<int> randomNums = new List<int>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(numbers.Count);
                randomNums.Add(numbers[index]);
            }
            return randomNums;
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
