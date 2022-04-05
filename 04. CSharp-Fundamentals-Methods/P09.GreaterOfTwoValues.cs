using System;

namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int numberFirst = int.Parse(Console.ReadLine());
                int numberSecond = int.Parse(Console.ReadLine());
                int maxNumber = GetMax(numberFirst, numberSecond);
                Console.WriteLine(maxNumber);
            }
            else if (type == "char")
            {
                char charOne = char.Parse(Console.ReadLine());
                char charTwo = char.Parse(Console.ReadLine());
                char maxchar = GetMax(charOne, charTwo);
                Console.WriteLine(maxchar);
            }
            else if (type == "string")
            {
                string textOne = Console.ReadLine();
                string textTwo = Console.ReadLine();
                string maxText = GetMax(textOne, textTwo);
                Console.WriteLine(maxText);
            }
        }

        static int GetMax(int numberOne, int NumberTwo)
        {
            return numberOne >= NumberTwo ? numberOne : NumberTwo;            
        }

        static char GetMax(char charOne, char charTwo)
        {
            return charOne >= charTwo ? charOne : charTwo;
        }

        static string GetMax(string stringOne, string stringTwo)
        {
            return stringOne.CompareTo(stringTwo) >= 0 ? stringOne : stringTwo; 
        }
    }
}
