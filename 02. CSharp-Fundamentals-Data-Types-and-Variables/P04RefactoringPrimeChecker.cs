using System;

namespace P04RefactoringPrimeChecker
{
    internal class P04RefactoringPrimeChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isCheck = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isCheck = false;
                        break;
                    }
                }

                if (isCheck)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }

        }
    }
}
