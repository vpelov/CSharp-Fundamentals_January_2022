using System;

namespace P10.MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumOfEvenDigits = GetSumOfEvenDigits(inputNumber);
            int sumOfOddDigits = GetSumOfOddDigits(inputNumber);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOfEvenDigits, sumOfOddDigits));
        }

        static int GetSumOfEvenDigits(int number) 
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return Math.Abs(sum);
        }

        static int GetSumOfOddDigits(int number) 
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return Math.Abs(sum);
        }

        static int GetMultipleOfEvenAndOdds(int even, int odd) 
        {
            return even * odd;
        }

    }
}
