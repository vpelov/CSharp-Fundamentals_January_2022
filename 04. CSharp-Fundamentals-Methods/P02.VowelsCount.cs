using System;
using System.Linq;

namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();

            Console.WriteLine(CheckVowels(someText.ToLower()));
        }

        static int CheckVowels(string text)
        {
            int countVowels = 0;
            char[] charsVowels = new char[] {'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < text.Length; i++)
            {
                if (charsVowels.Contains(text[i]))
                {
                    countVowels++;
                }
            }
            return countVowels;
        }
    }
}
