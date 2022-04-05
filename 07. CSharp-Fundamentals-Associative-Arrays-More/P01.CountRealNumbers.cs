using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input

            int[] inputData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            SortedDictionary<int, int> data = new SortedDictionary<int, int>();

            foreach (int item in inputData)
            {
                if (data.ContainsKey(item))
                {
                    data[item] += 1;
                }
                else
                {
                    data.Add(item, 1);
                }
            }

            // Print

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
