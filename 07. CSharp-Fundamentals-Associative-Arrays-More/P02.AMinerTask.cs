using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourseDict = new Dictionary<string, int>();

            string inputData = Console.ReadLine();

            while (inputData != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourseDict.ContainsKey(inputData))
                {
                    resourseDict[inputData] += quantity;
                }
                else
                {
                    resourseDict.Add(inputData, quantity);
                }

                inputData = Console.ReadLine(); 
            }

            foreach (var item in resourseDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
