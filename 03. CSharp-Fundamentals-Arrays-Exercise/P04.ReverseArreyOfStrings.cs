using System;

namespace P04.ReverseArreyOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().Split(" ");

            string[] arrayReverse = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                for (int j = array.Length -1 - i; j >= 0 ; j--)
                {
                arrayReverse[j] = text;
                }
            }
            Console.WriteLine(string.Join(" ", arrayReverse));
        }
    }
}
