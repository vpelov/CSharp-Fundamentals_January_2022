using System;

namespace P02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            char firstChar = Convert.ToChar(first);
            string second = Console.ReadLine();
            char secondChar = Convert.ToChar(second);

            string text = Console.ReadLine();

            int totalSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentCh = Convert.ToChar(text[i]);

                if (currentCh > firstChar && currentCh < secondChar)
                {
                    totalSum += currentCh;
                }
            }

            Console.WriteLine($"{totalSum}");

        }
    }
}

