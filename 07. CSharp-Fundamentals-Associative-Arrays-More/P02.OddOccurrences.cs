using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input

            string[] inputData = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> dataDictionary = new Dictionary<string, int>();

            foreach (string item in inputData)
            {
                if (dataDictionary.ContainsKey(item))
                {
                    dataDictionary[item] += 1;
                }
                else
                {
                dataDictionary.Add(item, 1);                        
                }
            }

            // Output data

            foreach (var item in dataDictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }

        }
    }
}
