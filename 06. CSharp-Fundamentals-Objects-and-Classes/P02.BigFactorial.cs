using System;
using System.Numerics;

namespace P02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetFactorial(n);
        }

        static void GetFactorial(int Number)
        {
            BigInteger total = 1;
            for (int i = 1; i <= Number; i++)
            {
                total *= i;
            }
            Console.WriteLine(total);
        }


    }
}
