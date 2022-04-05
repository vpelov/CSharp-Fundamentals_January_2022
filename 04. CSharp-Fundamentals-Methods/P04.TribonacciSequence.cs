using System;

namespace P04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            GetNumberTribonacci(num);
        }

        static void GetNumberTribonacci(int number)
        {
            int first = 1;
            int second = 0;
            int third = 0;

            for (int i = 0; i < number; i++)
            {
                int sumPrint = first + second + third;
                Console.Write($"{sumPrint} ");
                first = second;
                second = third;
                third = sumPrint;
            }
        }

    }
}
