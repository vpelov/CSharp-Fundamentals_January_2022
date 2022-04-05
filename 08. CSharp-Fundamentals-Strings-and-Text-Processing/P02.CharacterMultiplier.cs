using System;
using System.Linq;

namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string textOne = inputArray[0];
            string textTwo = inputArray[1];
            int sum = 0;

            if (textOne.Length >= textTwo.Length)
            {
                for (int i = 0; i < textTwo.Length; i++)
                {
                    int one = textOne[i];
                    int two = textTwo[i];
                    sum += one * two;
                }

                if (textOne.Length - textTwo.Length > 0)
                {

                    for (int i = textOne.Length - 1; i >= textTwo.Length; i--)
                    {
                        sum += textOne[i];
                    }
                }
            }
            else if (textOne.Length < textTwo.Length)
            {
                for (int j = 0; j < textOne.Length; j++)
                {
                    int first = textOne[j];
                    int second = textTwo[j];

                    sum += first * second;
                }

                for (int i = textTwo.Length - 1; i >= textOne.Length; i--)
                {
                    sum += textTwo[i];
                }

            }

            Console.WriteLine(sum);
        }
    }
}
