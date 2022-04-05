using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallestNumberFromThreeNum(numberOne, numberTwo, numberThree));
        }

        static int GetSmallestNumberFromThreeNum(int num1, int num2, int num3)
        {
            int minNum = int.MaxValue;
            int[] array = new int[3] {num1, num2, num3};

            for (int i = 0; i < 3; i++)
            {
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
            }

            return minNum;            
        }
    }
}
