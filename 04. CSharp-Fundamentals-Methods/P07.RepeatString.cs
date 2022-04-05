using System;
using System.Text;

namespace P07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            int numberRepeat = int.Parse(Console.ReadLine());

            string newStringWithReped = RepedTheString(inputString, numberRepeat);
            Console.WriteLine(newStringWithReped);

        }

        private static string RepedTheString(string text, int number)
        {
            StringBuilder bigString = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                bigString.Append(text);
            }
            return bigString.ToString();
        }

    }
}
