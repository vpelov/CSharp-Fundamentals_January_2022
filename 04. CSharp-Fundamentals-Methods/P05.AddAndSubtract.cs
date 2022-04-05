using System;

namespace P05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int sumOneAndTwo = GetSumFirstAndSecondNumber(numberOne, numberTwo);
            Console.WriteLine(GetSubtract(sumOneAndTwo, numberThree));
        }

        static int GetSumFirstAndSecondNumber(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;        
        }

        static int GetSubtract(int num1, int num2)
        {
            int subtract = num1 - num2;
            return subtract;
        
        }

    }
}
