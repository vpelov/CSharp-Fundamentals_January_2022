using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            numberList.RemoveAll(x => x < 0);

            numberList.Reverse();

            if (numberList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numberList));
            }

        }
    }
}
