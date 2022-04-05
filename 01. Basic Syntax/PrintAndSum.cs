using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write($"{i} ");
                total += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {total}");
        }
    }
}
