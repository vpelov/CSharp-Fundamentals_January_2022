using System;

namespace P04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            printFirstTriangle(number);
            printSecondTriangle(number);
        }

        static void printFirstTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void printSecondTriangle(int num)
        {
            for (int i = num; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
