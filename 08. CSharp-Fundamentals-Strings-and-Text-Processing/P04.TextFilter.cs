using System;
using System.Linq;

namespace P04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string someText = Console.ReadLine();

            foreach (string item in bannedWord)
            {
                someText = someText.Replace(item, new string('*', item.Length));
            }

            Console.WriteLine(someText);
        }
    }
}
