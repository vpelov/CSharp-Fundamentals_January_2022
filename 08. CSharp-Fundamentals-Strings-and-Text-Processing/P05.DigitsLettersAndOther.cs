using System;

namespace P05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            foreach (char item in chars)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else if (!char.IsLetterOrDigit(item))
                {
                    symbols += item;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);


        }
    }
}
