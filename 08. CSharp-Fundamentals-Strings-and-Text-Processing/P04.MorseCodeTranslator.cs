using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
                  'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                  'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                  ',', '.', '?' };

            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----",
                "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                "-----", "--..--", ".-.-.-", "..--.." };

            List<char> printText = new List<char>();

            string[] inputData = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            for (int i = 0; i < inputData.Length; i++)
            {
                string[] word = inputData[i].Split(' ');

                for (int j = 0; j < word.Length; j++)
                {
                    for (int k = 0; k < morse.Length; k++)
                    {
                        if (morse[k] == word[j])
                        {
                            printText.Add(alphabet[k]);
                            break;
                        }
                    }
                }

                printText.Add(' ');
            }

                Console.WriteLine(String.Join("", printText));
        }
    }
}
