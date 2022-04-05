using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string cryptText = Console.ReadLine();

            while (cryptText != "find")
            {
                StringBuilder newText = new StringBuilder();
                int count = 0;

                for (int i = 0; i < cryptText.Length; i++)
                {


                    char currentCh = cryptText[i];
                    int num = Convert.ToInt32(currentCh);

                    num -= (key[count]);
                    char newChar = Convert.ToChar(num);

                    newText.Append(newChar);
                    count++;

                    if (count == key.Length)
                    {
                        count = 0;
                    }


                }

                List<string> printList = GetResult(newText);

                Console.WriteLine($"Found {printList[0]} at {printList[1]}");

                cryptText = Console.ReadLine();
            }
        }

        static List<string> GetResult(StringBuilder newText)
        {
            List<string> printList = new List<string>();

            int firstIndex = newText.ToString().IndexOf('&');
            int lastIndex = newText.ToString().LastIndexOf('&');
            string firstText = newText.ToString().Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            printList.Add(firstText);
            
            int firstIndexOne = newText.ToString().IndexOf('<');
            int lastIndexTwo = newText.ToString().LastIndexOf('>');
            string secondText = newText.ToString().Substring(firstIndexOne + 1, lastIndexTwo - firstIndexOne - 1);
            printList.Add(secondText);

            return printList;
        }


    }
}
