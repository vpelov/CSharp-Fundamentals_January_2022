using System;
using System.Linq;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] inputData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal totalSum = 0;

            for (int i = 0; i < inputData.Length; i++)
            {
                string num = inputData[i];
                num = num.Remove(0, 1);
                num = num.Remove(num.Length - 1, 1);
                decimal number = decimal.Parse(num); 

                char[] currentCharArray = inputData[i].ToCharArray();

                if (char.IsUpper(currentCharArray[0]))
                {
                    decimal divide = currentCharArray[0] - 64;
                    totalSum += number / divide;
                }
                else if (char.IsLower(currentCharArray[0]))
                {
                    decimal multiply = currentCharArray[0] - 96;
                    totalSum += number * multiply;
                }

                if (char.IsUpper(currentCharArray[currentCharArray.Length - 1]))
                {
                    decimal substract = currentCharArray[currentCharArray.Length - 1] - 64;
                    totalSum -= substract;
                }
                else if (char.IsLower(currentCharArray[currentCharArray.Length - 1]))
                {
                    decimal add = currentCharArray[currentCharArray.Length - 1] - 96;
                    totalSum += add;
                }
               
            }

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
