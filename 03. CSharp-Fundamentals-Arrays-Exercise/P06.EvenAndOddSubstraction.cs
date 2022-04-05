using System;
using System.Linq;

namespace P06.EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    evenSum += numberArray[i];
                }
                else if (numberArray[i] % 2 != 0)
                {
                    oddSum += numberArray[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
