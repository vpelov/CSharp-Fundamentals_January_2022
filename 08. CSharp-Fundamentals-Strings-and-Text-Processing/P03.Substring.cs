using System;

namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            while (secondText.Contains(firstText))
            {
                if (secondText.Contains(firstText))
                {
                    int startIndex = secondText.IndexOf(firstText);
                    secondText = secondText.Remove(startIndex, firstText.Length);
                }
            }

            Console.WriteLine(secondText);
        }
    }
}
