using System;

namespace StrongNumber2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int workNumber = number;

            int totalFactoriel = 0;

            while (workNumber > 0)
            {
                int currentNumber = workNumber % 10;
                int currentFactoriel = 1;

                for (int i = currentNumber; i > 1; i--)
                {
                    currentFactoriel *= i;
                }

                totalFactoriel += currentFactoriel;
                workNumber /= 10;

            }

            if (totalFactoriel == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
