using System;
using System.Linq;

namespace P02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStrings = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string printString = string.Empty;

            for (int i = 0; i < arrayStrings.Length; i++)
            {
                for (int j = 0; j < arrayStrings[i].Length; j++)
                {
                    printString += arrayStrings[i];
                }
            }
            Console.WriteLine(printString);

        }
    }
}
