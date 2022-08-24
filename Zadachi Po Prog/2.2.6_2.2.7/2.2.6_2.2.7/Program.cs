using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._6_2._2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            int[,] arr = null;
            int uniqueLen;
            int[] unique;
            GetMatix(out row, out column, out arr);
            WriteMatrix(arr);
            //-------------------------------------------------------//
            //Console.WriteLine("B variant of 2.2.6");
            //SwapRow(arr);
            //WriteMatrix(arr);
            //-------------------------------------------------------//
            //Console.WriteLine("V variant of 2.2.6");
            //AddElementsIntoUniqueArr(arr, out uniqueLen, out unique);
            //FindCountOfUniqueElementsInMatrix(uniqueLen, unique);
            //--------------------------------------------------------//
            Console.WriteLine("E variant of 2.2.6");
            MagicCube(arr);
            //--------------------------------------------------------//
            //Console.WriteLine("J variant of 2.2.6");
            //FindMinInRowMaxInColumn(arr);

            Console.ReadKey();
        }

        private static void FindMinInRowMaxInColumn(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int maxInCol = 0, minInRow = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    minInRow = maxInCol = arr[i, j];
                    //Find the min of the current row
                    for (int k = 0; k < rowLength; k++)
                    {
                        if (arr[i, k] < minInRow)
                        {
                            minInRow = arr[i, k];
                        }
                    }
                    //Find the max of the current column
                    for (int k = 0; k < columnLength; k++)
                    {
                        if (arr[k, j] > maxInCol)
                        {
                            maxInCol = arr[k, j];
                        }
                    }
                    if (minInRow == arr[i, j] && maxInCol == arr[i, j])
                    {
                        Console.WriteLine("Found an element : " + minInRow);
                        Console.ReadKey();
                    }
                }
            }
        }

        private static void MagicCube(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            int sumRow = 0;
            int sumCol = 0;
            int countMagic = 0;
            int[] sumRowArr = new int[rowLength];
            int[] sumColArr = new int[columnLength];

            for (int j = 0; j < columnLength; j++)
            {
                for (int i = 0; i < rowLength; i++)
                {
                    sumCol = sumCol + arr[i, j];
                }
                sumColArr[j] = sumCol;
                sumCol = 0;
            }

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    sumRow = sumRow + arr[i, j];
                }
                sumRowArr[i] = sumRow;
                sumRow = 0;
            }

            int sum1 = sumColArr.Sum();
            int sum2 = sumRowArr.Sum();
            for (int i = 0; i < rowLength; i++)
            {
                if (sumColArr[i] == sumRowArr[i] && sum1==sum2)
                {
                    countMagic++;
                }
            }

            Console.WriteLine(countMagic);
            if (countMagic == rowLength)
            {
                Console.WriteLine("Magic square");
            }
        }

        private static void FindCountOfUniqueElementsInMatrix(int uniqueLen, int[] unique)
        {
            int res = 0;
            for (int i = 0; i < uniqueLen; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                    if (unique[i] == unique[j])
                        break;

                // If not printed earlier,
                // then print it
                if (i == j)
                    res++;
            }
            Console.WriteLine(res);
        }

        private static void AddElementsIntoUniqueArr(int[,] arr, out int uniqueLen, out int[] unique)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            uniqueLen = rowLength * columnLength;
            unique = new int[uniqueLen];
            int a = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    unique[a] = arr[i, j];
                    a++;
                }

            }
        }

        private static void SwapRow(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            Console.WriteLine("Enter 1st Row that want to swap");
            int row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2st Row that want to swap");
            int row2 = int.Parse(Console.ReadLine());
            row1 = row1 - 1;
            row2 = row2 - 1;
            int forSave = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    forSave = arr[row2, j];
                    arr[row2, j] = arr[row1, j];
                    arr[row1, j] = forSave;
                }
            }
        }
        #region
        private static void GetMatix(out int row, out int column, out int[,] arr)
        {
            
            Console.WriteLine("Enter Row Value");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            column = int.Parse(Console.ReadLine());
            arr = new int[row, column];
            Console.WriteLine("Enter Elements one by one");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);

                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void WriteMatrix(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int columnLength = arr.GetLength(1);
            Console.WriteLine("Given Matrix");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write("\t{0}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion

    }
}
