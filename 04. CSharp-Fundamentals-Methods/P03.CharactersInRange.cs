using System;
using System.Linq;

namespace P03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chOne = char.Parse(Console.ReadLine());
            char chTwo = char.Parse(Console.ReadLine());

            PrintingCharactersRange(chOne, chTwo);
        }

        static void PrintingCharactersRange(char chFirst, char chSecond)
        {
                      
            int smallChar = 0;
            int bigChar = 0;

            if (chFirst < chSecond)
            {
                smallChar = chFirst;
                bigChar = chSecond;
            }
            else
            {
                smallChar = chSecond;
                bigChar = chFirst;
            }

            for (int i = smallChar + 1; i < bigChar; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }

        }
    }
}
