using System;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputData = Console.ReadLine();

            char[] text = inputData.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                int currentCh = text[i];
                currentCh += 3;

                char printCh = (char)currentCh;
                Console.Write(printCh);
            }

        }
    }
}
