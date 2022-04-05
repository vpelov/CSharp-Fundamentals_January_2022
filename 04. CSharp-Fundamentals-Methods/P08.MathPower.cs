using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(GetPower(numberOne, numberTwo));
        }

        static double GetPower(double numFirst, double numSekond)
        {
            double totalSum = 1;
            for (int i = 0; i < numSekond; i++)
            {
                totalSum *= numFirst;
            }
            return totalSum;
        }
    }
}
