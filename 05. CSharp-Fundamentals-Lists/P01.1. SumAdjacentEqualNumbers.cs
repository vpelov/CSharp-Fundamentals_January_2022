using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._1._SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> inputList = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(String.Join(' ', inputList));
        }
    }
}
