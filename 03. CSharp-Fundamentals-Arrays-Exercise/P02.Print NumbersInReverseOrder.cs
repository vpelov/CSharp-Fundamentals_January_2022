using System;
using System.Linq;

namespace P02.Print_NumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] array = new int[numbers];

            for (int i = 0; i < array.Length; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                array[i] = digit;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
