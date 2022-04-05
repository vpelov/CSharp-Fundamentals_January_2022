using System;

namespace P04.ReverseArreyOfStrings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ");

            Array.Reverse(array);
           
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
