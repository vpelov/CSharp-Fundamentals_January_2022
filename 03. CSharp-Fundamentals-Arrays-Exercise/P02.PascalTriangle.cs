using System;
using System.Linq;

namespace P02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetPascalTriangle(number);
        }

        static void GetPascalTriangle(int num)
        {
            int[] arrayPascalTriangleStart = new int[num];  

            for (int j = 0; j < arrayPascalTriangleStart.Length; j++)
            {
                int[] printArray = new int[num];

                for (int i = 0; i < arrayPascalTriangleStart.Length; i++)
                {

                    if (i == 0)
                    {
                        printArray[i] = 1;                       
                    }
                    else
                    {
                        printArray[i] = arrayPascalTriangleStart[i] + arrayPascalTriangleStart[i - 1];
                    }
                }

                for (int i = 0; i < printArray.Length; i++)   //Print array without zero
                {
                    if (printArray[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{printArray[i]} ");
                    }
                    
                }

                Console.WriteLine();
                arrayPascalTriangleStart = printArray;
            }

        }
    }
}
