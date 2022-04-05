using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> printResult = new List<int>();

            for (int i = 0; i < inputNumber.Count / 2 ; i++)
            {
                printResult.Add(inputNumber[i] + inputNumber[inputNumber.Count - 1 - i]);
            }

            if (inputNumber.Count % 2 != 0)
            {
                printResult.Add(inputNumber[inputNumber.Count / 2]);
            }

            Console.WriteLine(String.Join(' ', printResult));

        }
    }
}
