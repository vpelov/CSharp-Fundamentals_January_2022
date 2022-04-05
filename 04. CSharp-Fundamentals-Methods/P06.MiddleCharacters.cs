using System;

namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inText = Console.ReadLine();

            char[] array = ReturnMiddleChar(inText);

            foreach (char item in array)
            {
                Console.Write(item);
            }
        }

        static char[] ReturnMiddleChar(string text)
        {
            char[] chMiddle = text.ToCharArray();
            char[] arreyReturn = new char[2];

            if (text.Length % 2 != 0)
            {
                int middle = text.Length / 2;
                arreyReturn[0] = text[middle];
            }
            else if (text.Length % 2 == 0)
            {
                int middle = text.Length / 2;
                arreyReturn[0] = text[middle - 1];
                arreyReturn[1] = text[middle];
            }

            return arreyReturn;
        }
    }
}
