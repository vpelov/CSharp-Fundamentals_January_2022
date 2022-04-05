using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNumber = Console.ReadLine().Split().ToList();
            string inputText = Console.ReadLine();


            List<string> result = new List<string>();

            for (int i = 0; i < inputNumber.Count; i++)
            {
                int sum = GeSumOfNumberfromString(inputNumber[i]);

                if (sum >= inputText.Length)
                {
                    sum %= inputText.Length;
                }

                char symbol = inputText[sum];
               result.Add(symbol.ToString());
                inputText = inputText.Remove(sum, 1);

            }

                Console.WriteLine(String.Join("", result));

        }



        static int GeSumOfNumberfromString(string textNumber)
        {
            int num = int.Parse(textNumber);
            int sum = 0;

            while (num != 0)
            {
                int currentNum = num % 10;
                sum += currentNum;
                num /= 10;
            }

            return sum;
        }
    }
}
