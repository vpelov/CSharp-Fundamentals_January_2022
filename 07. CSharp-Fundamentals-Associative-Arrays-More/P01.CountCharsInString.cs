using System;
using System.Collections.Generic;

namespace P01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> checkDict = new Dictionary<char, int>();

            string inputText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                char currentChar = inputText[i];

                if (currentChar == 32)
                {
                    continue;
                }
                else
                {
                    if (checkDict.ContainsKey(currentChar))
                    {
                        checkDict[currentChar]++;
                    }
                    else
                    {
                        checkDict.Add(currentChar, 1);
                    }
                }
            }

            foreach (var item in checkDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
