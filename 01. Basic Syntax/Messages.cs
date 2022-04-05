using System;

namespace P05Messages
{
    internal class Messages
    {
        static void Main(string[] args)
        {
            int numberDigits = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numberDigits; i++)
            {
                string number = Console.ReadLine();
                int numberLenght = number.Length;
                int currentDigit = int.Parse(number) % 10;
                int offset = (currentDigit - 2) * 3;

                if (currentDigit == 0)
                {
                    message += (char)(currentDigit + 32);
                    continue;
                }

                if (currentDigit == 8 || currentDigit == 9)
                {
                    offset++;
                }


                int letterIndex = offset + numberLenght - 1;
                message += (char)(letterIndex + 97);

            }

            Console.WriteLine(message);
        }
    }
}
