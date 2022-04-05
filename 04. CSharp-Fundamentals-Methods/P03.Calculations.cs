using System;

namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                getAdd(numberOne, numberTwo);
            }
            else if (operation == "divide")
            {
                getDivaide(numberOne, numberTwo);
            }
            else if (operation == "subtract")
            {
                getSubtract(numberOne, numberTwo);
            }
            else if (operation == "multiply")
            {
                getMultiply(numberOne, numberTwo);
            }
        }

        static void getAdd(int num1, int num2)
        {
            int div = num1 + num2;
            Console.WriteLine(div);
        }

        static void getDivaide(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine(div);
        }

        static void getSubtract(int num1, int num2)
        {
            int div = num1 - num2;
            Console.WriteLine(div);
        }

        static void getMultiply(int num1, int num2)
        {
            int div = num1 * num2;
            Console.WriteLine(div);
        }
    }
}
