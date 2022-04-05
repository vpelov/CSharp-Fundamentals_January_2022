using System;

namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberFirst = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int numberSecond = int.Parse(Console.ReadLine());

            Console.WriteLine(GetOperation(numberFirst, numberSecond, operation));

        }

        static int GetOperation(int num1, int num2, char operation)
        {
            if (operation.Equals('+'))
            {
                return num1 + num2;
            }
            else if (operation.Equals('-'))
            {
                return (num1 - num2);
            }
            else if (operation.Equals('*'))
            {
                return num1 * num2;
            }
            else if (operation.Equals('/'))
            {
                return num1 / num2;
            }
            return 0;
        
        }
    }
}
