using System;

namespace P03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetNumberFibonacci(number);
        }

        static void GetNumberFibonacci(int num)
        {
            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else
            {

                int[] array = new int[num];
                array[0] = 1;
                array[1] = 1;

                for (int i = 2; i < num; i++)
                {
                    array[i] = array[i - 1] + array[i - 2];
                }

                Console.WriteLine(array[num - 1]);
            }
        }

    }
}
