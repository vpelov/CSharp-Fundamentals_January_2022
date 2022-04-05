using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int p = 1; p <= i; p++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }


        }
    }
}
