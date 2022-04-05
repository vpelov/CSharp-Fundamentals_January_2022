using System;

namespace P03FloatingEquality
{
    internal class FloatingEquality
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001m;

            bool difference = (Math.Abs(firstNumber) - Math.Abs(secondNumber)) < eps;

            if (difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }           
        }
    }
}
