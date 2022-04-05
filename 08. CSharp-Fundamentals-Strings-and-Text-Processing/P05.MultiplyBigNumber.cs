using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberTwo == 0)
            {
                Console.WriteLine("0");
            }
            else
            {


                char[] bigNumber = numberOne.ToCharArray();
                List<int> printList = new List<int>();

                int division = 0;

                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {

                    int currentNumber = ((bigNumber[i] - '0') * numberTwo) + division;
                    division = currentNumber / 10;
                    int addNumber = currentNumber % 10;

                    printList.Add(addNumber);

                }

                if (division > 0)
                {
                    printList.Add(division);
                }


                printList.Reverse();

                Console.WriteLine(String.Join("", printList));
            }

        }
    }
}
