using System;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetFactorialDivision(numberOne, numberTwo):f2}");
        }

        static double GetFactorialDivision(int numOne, int numTwo)
        {
            double result = 0;
            double fOne = 1;
            double fTwo = 1;

            for (int i = 1; i <= numOne; i++)
            {
                fOne *=i;
            }

            for (int j = 1; j <= numTwo; j++)
            {
                fTwo *= j;
            }

            return result = fOne / fTwo;

        }
    }
}
